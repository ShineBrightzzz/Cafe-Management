-- Create Ingredient table
IF OBJECT_ID('ingredients', 'U') IS NOT NULL
    DROP TABLE ingredients;
GO

CREATE TABLE ingredients (
    ingredient_id NVARCHAR(50) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    unit NVARCHAR(20) NOT NULL,
    quantity INT NOT NULL,
    unit_price DECIMAL(10,2) NOT NULL
);
GO

-- Create Recipe table
IF OBJECT_ID('recipes', 'U') IS NOT NULL
    DROP TABLE recipes;
GO

CREATE TABLE recipes (
    recipe_id NVARCHAR(50) PRIMARY KEY,
    product_id NVARCHAR(50) NOT NULL,
    ingredient_id NVARCHAR(50) NOT NULL,
    amount DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (product_id) REFERENCES products(product_id),
    FOREIGN KEY (ingredient_id) REFERENCES ingredients(ingredient_id)
);
GO

-- Modify ImportInvoiceDetail table to use ingredients
IF OBJECT_ID('import_invoice_details', 'U') IS NOT NULL
    DROP TABLE import_invoice_details;
GO

CREATE TABLE import_invoice_details (
    import_invoice_id NVARCHAR(50),
    ingredient_id NVARCHAR(50),
    quantity INT NOT NULL,
    unit_price DECIMAL(10,2) NOT NULL,
    discount DECIMAL(10,2) NOT NULL,
    total_price DECIMAL(10,2) NOT NULL,
    PRIMARY KEY (import_invoice_id, ingredient_id),
    FOREIGN KEY (import_invoice_id) REFERENCES import_invoices(import_invoice_id),
    FOREIGN KEY (ingredient_id) REFERENCES ingredients(ingredient_id)
);
GO

-- Insert sample ingredients
INSERT INTO ingredients (ingredient_id, name, unit, quantity, unit_price) VALUES
('ING001', 'Hạt cà phê', 'kg', 100, 200000),
('ING002', 'Sữa tươi', 'liter', 50, 30000),
('ING003', 'Đường', 'kg', 30, 20000),
('ING004', 'Hạt ca cao', 'kg', 20, 180000),
('ING005', 'Lá trà', 'kg', 15, 150000);
GO
