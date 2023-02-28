using FreeWebService;

Console.WriteLine("Testing Legislatie Just endpoint!");

var _soapClient = new FreeWebServiceClient();

try{
    var token = await _soapClient.GetTokenAsync();
    Console.WriteLine($"Successfully received token {token}");
} catch(Exception ex){
    Console.WriteLine($"Failed in receiving token. Errpr: {ex.Message}");
    throw;
}
