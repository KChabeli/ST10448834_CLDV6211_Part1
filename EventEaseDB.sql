-- Create the database
CREATE DATABASE EventEaseDB;

-- Use the database
USE EventEaseDB;

-- Create the Venues table
CREATE TABLE Venues (
    VenueId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Location NVARCHAR(200) NOT NULL,
    Capacity INT NOT NULL,
    ImageUrl NVARCHAR(255) -- Placeholder image URL
);

-- Insert sample venue
INSERT INTO Venues (Name, Location, Capacity, ImageUrl)
VALUES ('Grand Hall', '123 Main St, Cape Town', 300, 'https://via.placeholder.com/150');

SELECT * FROM Venues;

-- Create the Events table
CREATE TABLE Events (
    EventId INT PRIMARY KEY IDENTITY(1,1),
    EventName NVARCHAR(100) NOT NULL,
    EventDate DATETIME NOT NULL,
    Description NVARCHAR(500),
    ImageUrl NVARCHAR(255), -- Placeholder image URL
    VenueId INT NOT NULL,
    FOREIGN KEY (VenueId) REFERENCES Venues(VenueId) ON DELETE CASCADE
);

-- Insert sample event
INSERT INTO Events (EventName, EventDate, Description, ImageUrl, VenueId)
VALUES ('Tech Conference 2025', '2025-06-15 10:00:00', 'A technology-focused conference.', 'https://via.placeholder.com/150', 1);

SELECT * FROM Events;

-- Create the Bookings table
CREATE TABLE Bookings (
    BookingId INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(150) NOT NULL,
    NumberOfTickets INT NOT NULL,
    BookingDate DATETIME DEFAULT GETDATE(),
    EventId INT NOT NULL,
    FOREIGN KEY (EventId) REFERENCES Events(EventId) ON DELETE CASCADE
);

-- Insert sample booking
INSERT INTO Bookings (FullName, Email, NumberOfTickets, EventId)
VALUES ('Jane Doe', 'jane.doe@example.com', 2, 1);

SELECT * FROM Bookings;

