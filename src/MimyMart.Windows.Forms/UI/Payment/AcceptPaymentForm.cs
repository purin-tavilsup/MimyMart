﻿using System.Diagnostics.CodeAnalysis;
using MimyMart.Application.Common.Enums;
using MimyMart.Application.Common.Extensions;
using MimyMart.Application.Common.Interfaces;

namespace MimyMart.Windows.Forms.UI.Payment
{
    [ExcludeFromCodeCoverage]
	public partial class AcceptPaymentForm : Form
    {
        private readonly ISaleService _saleService;
        private readonly IList<decimal> _values;
		private readonly MessageForm _messageForm;
        private readonly IReadOnlyDictionary<int, string> _paymentTypeDictionary;
        private PaymentType _selectedPaymentType;
        private bool _isPaymentTypeSelected;
        private decimal _amount;
        private string _pendingStringValue;
		
        public AcceptPaymentForm(IStoreConstants storeConstants,
								 ISaleService saleService,
								 MessageForm messageForm)
        {
			_saleService = saleService;
            _paymentTypeDictionary = storeConstants.PaymentTypes;
			_messageForm = messageForm;

            InitializeComponent();

			_pendingStringValue = string.Empty;
            _values = new List<decimal>();
        }

        private void ResetPaymentTypeSelection()
		{
            // Default to cash
            _selectedPaymentType = PaymentType.Cash;
            _isPaymentTypeSelected = true;

            PaymentTypeLabel.Text = _paymentTypeDictionary[(int)_selectedPaymentType];
        }

        public new void ShowDialog()
        {
            _pendingStringValue = string.Empty;
            _values.Clear();
			NoteTextBox.Texts = string.Empty;

			ResetPaymentTypeSelection();

			var balanceRemaining = _saleService.CalculateBalanceRemaining();

			BalanceRemainingLabel.Text = $"{balanceRemaining:N}";

			var isRefundInvoice = _saleService.IsRefundInvoice();

			if (!isRefundInvoice)
			{
				ConfigureFormForRegularPayment();
			}
			else
			{
				ConfigureFormForRefund(balanceRemaining);
			}
			
			base.ShowDialog();
        }

		private void ConfigureFormForRegularPayment()
		{
			_amount = 0m;
			
			DisplayValue(_amount);

			AcceptPaymentButton.Visible = true;
			RefundButton.Visible = false;
			KeypadPanel.Enabled = true;
		}

		private void ConfigureFormForRefund(decimal refundAmount)
		{
			_amount = refundAmount;
			
			DisplayValue(_amount);

			NoteTextBox.Texts = "Refund";
			RefundButton.Visible = true;
			AcceptPaymentButton.Visible = false;
			KeypadPanel.Enabled = false;
		}

        private bool ValidatePaymentType()
		{
			if (!_isPaymentTypeSelected)
            {
				_messageForm.BringToFront();
				_messageForm.ShowDialog("กรุณาเลือกวิธีการชำระเงิน", "วิธีการชำระเงินยังไม่ถูกเลือก");

				return false;
			}

			return true;
		}

        private void AcceptPaymentButton_Click(object sender, EventArgs e)
        {
            if (!ValidatePaymentType())
				return;

			CalculateLatestAmount();

			var note = NoteTextBox.Texts.Trim();

            _saleService.AddPayment(_selectedPaymentType, _amount, note);
			
            Hide();
        }

		private void RefundButton_Click(object sender, EventArgs e)
		{
			if (!ValidatePaymentType())
				return;

			var note = NoteTextBox.Texts.Trim();

			_saleService.AddPayment(_selectedPaymentType, _amount, note);
			
			Hide();
		}

        private void CancelAcceptPaymentButton_Click(object sender, EventArgs e)
        {
			Hide();
        }

		private void PayByCashButton_Click(object sender, EventArgs e)
		{
			ChangePaymentType(PaymentType.Cash);
        }

		private void PayByMoneyTransferButton_Click(object sender, EventArgs e)
		{
			ChangePaymentType(PaymentType.MoneyTransfer);
        }

		private void ChangePaymentType(PaymentType type)
		{
			_selectedPaymentType = type;
			_isPaymentTypeSelected = true;

			PaymentTypeLabel.Text = _paymentTypeDictionary[(int) type];

			var isRefundInvoice = _saleService.IsRefundInvoice();

			AcceptPaymentButton.Visible = !isRefundInvoice;
		}

        private void AddByBankNoteValue(decimal value)
        {
			_pendingStringValue = string.Empty;

			_values.Add(value);
			_amount = _values.Sum();

			DisplayValue(_amount);
        }

		private void Add20Button_Click(object sender, EventArgs e)
		{
			AddByBankNoteValue(20m);
		}

		private void Add50Button_Click(object sender, EventArgs e)
		{
			AddByBankNoteValue(50m);
        }

		private void Add100Button_Click(object sender, EventArgs e)
		{
			AddByBankNoteValue(100m);
        }

		private void Add500Button_Click(object sender, EventArgs e)
		{
			AddByBankNoteValue(500m);
        }

		private void Add1000Button_Click(object sender, EventArgs e)
		{
			AddByBankNoteValue(1000m);
        }

		private void Digit1Button_Click(object sender, EventArgs e)
		{
            _pendingStringValue += "1";

            DisplayValue(_pendingStringValue);
        }

		private void Digit2Button_Click(object sender, EventArgs e)
		{
            _pendingStringValue += "2";

            DisplayValue(_pendingStringValue);
        }

		private void Digit3Button_Click(object sender, EventArgs e)
		{
            _pendingStringValue += "3";

            DisplayValue(_pendingStringValue);
        }

		private void Digit4Button_Click(object sender, EventArgs e)
		{
            _pendingStringValue += "4";

            DisplayValue(_pendingStringValue);
        }

		private void Digit5Button_Click(object sender, EventArgs e)
		{
            _pendingStringValue += "5";

            DisplayValue(_pendingStringValue);
        }

		private void Digit6Button_Click(object sender, EventArgs e)
		{
            _pendingStringValue += "6";

            DisplayValue(_pendingStringValue);
        }

		private void Digit7Button_Click(object sender, EventArgs e)
		{
            _pendingStringValue += "7";

            DisplayValue(_pendingStringValue);
        }

		private void Digit8Button_Click(object sender, EventArgs e)
		{
            _pendingStringValue += "8";

            DisplayValue(_pendingStringValue);
        }

		private void Digit9Button_Click(object sender, EventArgs e)
		{
            _pendingStringValue += "9";

            DisplayValue(_pendingStringValue);
        }

		private void DecimalPointButton_Click(object sender, EventArgs e)
		{
            if (_pendingStringValue.Contains("."))
                return;

			var decimalPoint = _pendingStringValue.HasValue() ? "." : "0.";

            _pendingStringValue += decimalPoint;

            DisplayValue(_pendingStringValue);
        }

		private void PlusButton_Click(object sender, EventArgs e)
		{
            CalculateLatestAmount();
            DisplayValue(_amount);
        }

        private void CalculateLatestAmount()
		{
            if (!_pendingStringValue.HasValue())
                return;

            var value = decimal.Parse(_pendingStringValue);

            _values.Add(value);
            _amount = _values.Sum();

            _pendingStringValue = string.Empty;
        }

		private void Digit0Button_Click(object sender, EventArgs e)
		{
            _pendingStringValue += "0";

            DisplayValue(_pendingStringValue);
        }

		private void ClearButton_Click(object sender, EventArgs e)
		{
            _amount = 0m;
            _values.Clear();
            _pendingStringValue = string.Empty;

            DisplayValue(_amount);
        }

		private void EqualButton_Click(object sender, EventArgs e)
		{
            CalculateLatestAmount();
            DisplayValue(_amount);
        }

        private void DisplayValue(decimal value)
		{
            DisplayValue($"{value:N}");
        }

        private void DisplayValue(string value)
        {
            PaymentAmountLabel.Text = value;
        }
    }
}
