CREATE PROCEDURE [dbo].[spUser_Get]
@Id uniqueidentifier
AS
begin
	SELECT Id, FirstName, LastName
	FROM dbo.[User]
	WHERE Id = @Id
end
