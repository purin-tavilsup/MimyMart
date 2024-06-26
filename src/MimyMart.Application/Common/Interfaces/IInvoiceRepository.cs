﻿using MimyMart.Domain.Entities;

namespace MimyMart.Application.Common.Interfaces;

public interface IInvoiceRepository
{
	int Add(Invoice invoice);

	bool RemoveById(int id);

	Invoice GetById(int id);

	IEnumerable<Invoice> GetByDateRange(DateOnly start, DateOnly end);

	IEnumerable<Invoice> GetByDate(DateOnly date);
}