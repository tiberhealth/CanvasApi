namespace CanvasApi.Client.Exceptions;

public class CanvasTransmissionException(string message, Exception exception = null): Exception(message, exception)
{
    
}