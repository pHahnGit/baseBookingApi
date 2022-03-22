CREATE PROCEDURE [dbo].[spUser_Delete]
@Id uniqueidentifier
AS
begin
	DELETE
	FROM dbo.[User]
	WHERE Id = @Id
end
