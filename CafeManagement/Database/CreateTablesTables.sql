-- filepath: d:\C#Proj\Cafe-Management\CafeManagement\Database\CreateTables.sql

-- Create tables table
CREATE TABLE tables (
    id VARCHAR(50) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    is_occupied BIT DEFAULT 0
);

-- Insert sample data
INSERT INTO tables (id, name, is_occupied) VALUES ('T001', 'Table 1', 0);
INSERT INTO tables (id, name, is_occupied) VALUES ('T002', 'Table 2', 0);
INSERT INTO tables (id, name, is_occupied) VALUES ('T003', 'Table 3', 1);
INSERT INTO tables (id, name, is_occupied) VALUES ('T004', 'Table 4', 0);
INSERT INTO tables (id, name, is_occupied) VALUES ('T005', 'Table 5', 1);
