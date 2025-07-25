INSERT INTO UserLevelTbl (level)
VALUES 
('Admin'),
('User'),
('Guest');


INSERT INTO UsersTbl (username, password, email, userlevel_id, status, modified_at, created_at)
VALUES
-- Admins (userlevel_id = 1)
('admin1', 'password123', 'admin1@example.com', 1, 1, GETDATE(), GETDATE()),
('admin2', 'password123', 'admin2@example.com', 1, 1, GETDATE(), GETDATE()),
('admin3', 'password123', 'admin3@example.com', 1, 1, GETDATE(), GETDATE()),
('admin4', 'password123', 'admin4@example.com', 1, 1, GETDATE(), GETDATE()),

-- Users (userlevel_id = 2)
('user1', 'password123', 'user1@example.com', 2, 1, GETDATE(), GETDATE()),
('user2', 'password123', 'user2@example.com', 2, 1, GETDATE(), GETDATE()),
('user3', 'password123', 'user3@example.com', 2, 1, GETDATE(), GETDATE()),

-- Guests (userlevel_id = 3)
('guest1', 'password123', 'guest1@example.com', 3, 1, GETDATE(), GETDATE()),
('guest2', 'password123', 'guest2@example.com', 3, 1, GETDATE(), GETDATE()),
('guest3', 'password123', 'guest3@example.com', 3, 1, GETDATE(), GETDATE());
