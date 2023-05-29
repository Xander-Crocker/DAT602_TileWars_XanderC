drop database if exists DAT602_TileWars_XanderC_2023;
create database DAT602_TileWars_XanderC_2023;
use DAT602_TileWars_XanderC_2023;

drop procedure if exists create_insert_tables;
delimiter // 
create procedure create_insert_tables()
begin

	drop table if exists `playerTable`;
    drop table if exists `gameTable`;
    drop table if exists `sessionTable`;
    drop table if exists `gameBoardTable`;
    drop table if exists `boardTileTable`;
    drop table if exists `itemTileTable`;

	-- Drop user cant be run with full script?
    -- IF EXISTS cant be used with drop user?

	drop user 'XDP'@'localhost'; 
    create user 'XDP'@'localhost' identified by '1234'; 
    grant all on DAT602_TileWars_XanderC_2023.* to 'XDP'@'localhost';

	CREATE TABLE `playerTable` (
		`playerID` int NOT NULL AUTO_INCREMENT,
		`PlayerFirstName` varchar(45) DEFAULT NULL,
		`PlayerLastName` varchar(45) DEFAULT NULL,
        `PlayerEmail` varchar(45) DEFAULT NULL,
		`playerUsername` varchar(45) DEFAULT NULL,
		`playerPassword` varchar(45) DEFAULT NULL,
		`playerLogAttempts` int DEFAULT '3',
		`playerLockedOut` boolean DEFAULT False,
		`playerIsAdmin` boolean DEFAULT False,
        `playerBoardID` int unique,
		PRIMARY KEY (`playerID`)
	);
    
    CREATE TABLE `gameTable` (
		`gameID` int NOT NULL auto_increment,
        `gameStatus` boolean DEFAULT False,
        `playerBoardID` int,
        PRIMARY KEY (`gameID`),
        FOREIGN KEY (`playerBoardID`) REFERENCES `playerTable`(`playerBoardID`)
    );
    
	CREATE TABLE `sessionTable` (
		`sessionID` int NOT NULL auto_increment,
        `playerID` int NOT NULL,
        `gameID` int NOT NULL,
        PRIMARY KEY (`sessionID`, `playerID`),
        FOREIGN KEY (`playerID`) REFERENCES `playerTable`(`playerID`),
        FOREIGN KEY (`gameID`) REFERENCES `gameTable`(`gameID`)
    );
    
    CREATE TABLE `boardTileTable` (
		`boardTileID` int NOT NULL,
        `playerBoardID` int,
        `tileRow` int NOT NULL,
        `tileColunm` int NOT NULL,
        PRIMARY KEY (`boardTileID`),
        FOREIGN KEY (`playerBoardID`) REFERENCES `playerTable`(`playerBoardID`)
    );
    
    CREATE TABLE `itemTileTable` (
		`itemID` int NOT NULL auto_increment,
		`boardTileID` int NOT NULL,
        PRIMARY KEY (`itemID`, `boardTileID`),
        FOREIGN KEY (`boardTileID`) REFERENCES `boardTileTable`(`boardTileID`)
    );
    
	-- TABLE POPULATION
    
	INSERT INTO `playerTable`(`PlayerFirstName`, `PlayerLastName`, `PlayerEmail`, `playerUsername`, `playerPassword`) 
	VALUES 
		('Mary', 'Smith', 'marysmith24@hotmail.com', 'Mary101', 'password1234');
	
	insert into `boardTileTable`(`boardTileID`, `tileRow`, `tileColunm`) -- populates the boardTileTable 
    VALUES -- this creates a 10x10 grid
		(1,1,1), (2,1,2), (3,1,3), (4,1,4), (5,1,5),
		(6,2,1), (7,2,2), (8,2,3), (9,2,4), (10,2,5),
		(11,3,1), (12,3,2), (13,3,3), (14,3,4), (15,3,5),
		(16,4,1), (17,4,2), (18,4,3), (19,4,4), (20,4,5),
		(21,5,1), (22,5,2), (23,5,3), (24,5,4), (25,5,5),
		(26,6,1), (27,6,2), (28,6,3), (29,6,4), (30,6,5),
		(31,7,1), (32,7,2), (33,7,3), (34,7,4), (35,7,5),
		(36,8,1), (37,8,2), (38,8,3), (39,8,4), (40,8,5),
		(41,9,1), (42,9,2), (43,9,3), (44,9,4), (45,9,5),
		(46,10,1), (47,10,2), (48,10,3), (49,10,4), (50,10,5);
		select * from `boardTileTable`;

END// 
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `registerPlayer`(
	IN pplayerUsername VARCHAR(45), 
    IN pplayerPassword VARCHAR(45)
    )
BEGIN
	IF pplayerUsername IN(
		SELECT `playerUsername`
		FROM playerTable
		)
    THEN
		SELECT 'ERROR: User already exists' AS MESSAGE;
	ELSE
		INSERT INTO `playerTable` (`playerUsername`, `playerPassword`)
		VALUES (pplayerUsername, pplayerPassword);
        
		SELECT CONCAT('User created: ', pplayerUsername) AS MESSAGE;
    END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `checkUsernameAndPassword`(IN pplayerUsername VARCHAR(45), IN pplayerPassword VARCHAR(45))
lockOut:BEGIN
	IF (
		SELECT `playerLogAttempts`
        FROM playerTable
        WHERE `playerUsername`
        ) < 1
    THEN
      SELECT 'WARNING: Account locked' AS MESSAGE;
        LEAVE lockOut;
	END IF;
    
	IF (
		SELECT `playerUsername`
		FROM `playerTable`
		WHERE
		`playerUsername` = pplayerUsername AND 
		`playerPassword` = pplayerPassword
        ) = pplayerUsername
	THEN
		SELECT 'Login succesful' AS MESSAGE;
	ELSE
		SELECT 'ERROR: Incorrect user details' AS MESSAGE;
	END IF;
END$$
DELIMITER ;

-- Make and test the database
call create_insert_tables;
CALL registerPlayer('Mary', 'Password1234');
CALL checkUsernameAndPassword('Mary','Password1234');
