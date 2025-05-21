-- Script to create sale_invoices and sale_invoice_details tables
USE CafeManagement;
GO

-- Drop the tables if they exist
IF OBJECT_ID('sale_invoice_details', 'U') IS NOT NULL
    DROP TABLE sale_invoice_details;
GO

IF OBJECT_ID('sale_invoices', 'U') IS NOT NULL
    DROP TABLE sale_invoices;
GO

-- Create the sale_invoices table
CREATE TABLE sale_invoices (
    id NVARCHAR(50) PRIMARY KEY,
    sale_date DATETIME NOT NULL,
    employee_id NVARCHAR(50) NULL,
    customer_id NVARCHAR(50) NULL,
    total_amount DECIMAL(18,2) NOT NULL
);
GO

-- Create the sale_invoice_details table
CREATE TABLE sale_invoice_details (
    invoice_id NVARCHAR(50),
    product_id NVARCHAR(50),
    quantity INT NOT NULL,
    unit_price DECIMAL(18,2) NOT NULL,
    discount DECIMAL(5,2) NOT NULL DEFAULT 0.0,    PRIMARY KEY (invoice_id, product_id),
    FOREIGN KEY (invoice_id) REFERENCES sale_invoices(id) ON DELETE CASCADE
);
GO
