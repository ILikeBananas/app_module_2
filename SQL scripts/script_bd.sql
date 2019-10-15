#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: Recette
#------------------------------------------------------------

CREATE TABLE Recette(
        Rct_Numero Int  Auto_increment  NOT NULL ,
        Rct_Nom    Varchar (30)
	,CONSTRAINT Recette_PK PRIMARY KEY (Rct_Numero)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Operation
#------------------------------------------------------------

CREATE TABLE Operation(
        Opr_ID          Int  Auto_increment  NOT NULL ,
        Opr_Numero      Int NOT NULL ,
        Opr_Position    Int NOT NULL ,
        Opr_Temps       Int NOT NULL ,
        Opr_Description Varchar (50) ,
        Opr_Quittance   Bool NOT NULL ,
        Rct_Numero      Int NOT NULL
	,CONSTRAINT Operation_PK PRIMARY KEY (Opr_ID)

	,CONSTRAINT Operation_Recette_FK FOREIGN KEY (Rct_Numero) REFERENCES Recette(Rct_Numero)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Status
#------------------------------------------------------------

CREATE TABLE Status(
        Stu_ID   Int  Auto_increment  NOT NULL ,
        Stu_Etat Varchar (50) NOT NULL
	,CONSTRAINT Status_PK PRIMARY KEY (Stu_ID)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Lot
#------------------------------------------------------------

CREATE TABLE Lot(
        Lot_Numero           Int  Auto_increment  NOT NULL ,
        Lot_Nom              Varchar (30) ,
        Lot_NumeroRecette    Int NOT NULL ,
        Lot_DateCreation     Datetime NOT NULL ,
        Lot_DateButoir       Datetime ,
        Lot_Quantite         Int NOT NULL ,
        Lot_QuantiteAtteinte Int ,
        Rct_Numero           Int NOT NULL ,
        Stu_ID               Int NOT NULL
	,CONSTRAINT Lot_PK PRIMARY KEY (Lot_Numero)

	,CONSTRAINT Lot_Recette_FK FOREIGN KEY (Rct_Numero) REFERENCES Recette(Rct_Numero)
	,CONSTRAINT Lot_Status0_FK FOREIGN KEY (Stu_ID) REFERENCES Status(Stu_ID)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Evenement
#------------------------------------------------------------

CREATE TABLE Evenement(
        Eve_ID      Int  Auto_increment  NOT NULL ,
        Eve_Date    Datetime NOT NULL ,
        Eve_Message Varchar (50) ,
        Lot_Numero  Int NOT NULL
	,CONSTRAINT Evenement_PK PRIMARY KEY (Eve_ID)

	,CONSTRAINT Evenement_Lot_FK FOREIGN KEY (Lot_Numero) REFERENCES Lot(Lot_Numero)
)ENGINE=InnoDB;

