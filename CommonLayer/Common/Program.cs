using Common.Contracts;
using Common.Models;
using Common.Serialization;

ObjectExample example = new ObjectExample();
example.message = "Hello World";

GenericMessage message = new GenericMessage(example);
GenericMessage message1 = new GenericMessage(1);


JsonSerializerService service = new JsonSerializerService();

string json = service.Serialize(message);
IMessage messageDes = service.Deserialize(json);


string json1 = service.Serialize(message1);
IMessage messageDes1 = service.Deserialize(json1);

Console.WriteLine();
