ALTER TABLE [Users]
ADD CONSTRAINT [CHK_PasswordLength] CHECK (DATALENGTH([Password]) >= 5)