# MimyMart

 A desktop POS application for a minimart

## Architecture

This solution uses Clean Architecture consisting of following layers:

- Application
- Domain
- Infrastructure
- Presentation

## Frontend

UI is a desktop application using Winforms  

## Backend

- SQLite is used as database stored locally in C:\ProgramData\MimyMart\db
- Dapper is used as ORM
- MediatR (CQRS) is used for interacting with database (handling commands and queries)
- Prism is used as Event Aggregator for handling notifications (Pub/Sub) between frontend and backend

## Installation Guide

- An executable file (MimyMart.Windows.Forms.exe) and its dependencies can be stored at any location, but default location is C:\ProgramData\MimyMart\bin.

- A pre-created database file (Store.db) should be stored in C:\ProgramData\MimyMart\db.
