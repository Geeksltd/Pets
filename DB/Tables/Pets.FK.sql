ALTER TABLE Pets ADD Constraint
                [FK_Pet.Type->PetType]
                FOREIGN KEY (Type)
                REFERENCES PetTypes (ID)
                ON DELETE NO ACTION;
GO