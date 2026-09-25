namespace CodigoHincha.Domain.Auth;

public enum UserRol
{
    User = 1,        // Usuario estándar (publicar, comentar, reaccionar)
    Moderator = 2,   // Moderador (borrar comentarios indebidos, aplicar baneos)
    Admin = 3        // Administrador (gestión total de la plataforma)
}