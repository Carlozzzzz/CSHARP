-- 1. UserLevelTbl
CREATE TABLE UserLevelTbl (
    id INT PRIMARY KEY IDENTITY(1,1),
    level VARCHAR(50) NOT NULL UNIQUE
);

-- 2. ThemesTbl
CREATE TABLE ThemesTbl (
    id INT PRIMARY KEY IDENTITY(1,1),
    background VARCHAR(20) NOT NULL,
    fontcolor VARCHAR(20) NOT NULL
);

-- 3. UsersTbl (depends on UserLevelTbl)
CREATE TABLE UsersTbl (
    id INT PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    userlevel_id INT NOT NULL,
    is_active BIT NOT NULL DEFAULT 1,
    modified_at DATETIME DEFAULT GETDATE(),
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (userlevel_id) REFERENCES UserLevelTbl(id)
);

-- 4. SuppliersTbl
CREATE TABLE SuppliersTbl (
    id INT PRIMARY KEY IDENTITY(1,1),
    supplier VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    mobilenumber VARCHAR(20) NOT NULL,
    modified_at DATETIME DEFAULT GETDATE(),
    created_at DATETIME DEFAULT GETDATE(),
    is_active BIT NOT NULL DEFAULT 1
);

-- 5. ProductsTbl (depends on SuppliersTbl)
CREATE TABLE ProductsTbl (
    id INT PRIMARY KEY IDENTITY(1,1),
    supplier_id INT NOT NULL,
    product VARCHAR(100) NOT NULL,
    description VARCHAR(MAX),
    quantity INT DEFAULT 0,
    is_active BIT NOT NULL DEFAULT 1,
    modified_at DATETIME DEFAULT GETDATE(),
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (supplier_id) REFERENCES SuppliersTbl(id)
);

-- 6. UserSettingsTbl (depends on UsersTbl and ThemesTbl)
CREATE TABLE UserSettingsTbl (
    id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL UNIQUE,
    theme_id INT NOT NULL,
    FOREIGN KEY (user_id) REFERENCES UsersTbl(id),
    FOREIGN KEY (theme_id) REFERENCES ThemesTbl(id)
);

-- 7. LogsTbl (depends on UsersTbl)
CREATE TABLE LogsTbl (
    id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL,
    action VARCHAR(255) NOT NULL,
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (user_id) REFERENCES UsersTbl(id)
);
