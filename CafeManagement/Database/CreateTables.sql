-- Script to create cafe_tables table
-- This should be run on your database

-- Drop the table if it exists
IF OBJECT_ID('cafe_tables', 'U') IS NOT NULL
    DROP TABLE cafe_tables;
GO

-- Create the table
CREATE TABLE cafe_tables (
    id NVARCHAR(50) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    status NVARCHAR(20) NOT NULL CHECK (status IN ('Available', 'Occupied', 'Reserved')),
    capacity INT NOT NULL,
    area NVARCHAR(50) NOT NULL
);
GO

-- Insert sample data
INSERT INTO cafe_tables (id, name, status, capacity, area)
VALUES 
    ('T001', 'Table 1', 'Available', 4, 'Ground Floor'),
    ('T002', 'Table 2', 'Occupied', 2, 'Ground Floor'),
    ('T003', 'Table 3', 'Reserved', 6, 'Ground Floor'),
    ('T004', 'Table 4', 'Available', 4, 'Balcony'),
    ('T005', 'Table 5', 'Available', 2, 'Balcony'),
    ('T006', 'VIP 1', 'Available', 8, 'VIP Section'),
    ('T007', 'VIP 2', 'Reserved', 8, 'VIP Section'),
    ('T008', 'Corner 1', 'Available', 2, 'Corner'),
    ('T009', 'Corner 2', 'Occupied', 2, 'Corner'),
    ('T010', 'Family Table', 'Available', 10, 'Family Section');
GO
