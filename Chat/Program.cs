
using System.Net.Security;
using Chat;
using Chat.Server;

var server = new ChatServer();

var person1 = new ChatClient("Hubert", server);
var person2 = new ChatClient("Fridtjof", server);
var person3 = new ChatClient("Frode", server);

person1.Say("Eg heiter Hubert");
person2.Say("Eg heiter Fridtjof");
person3.Say("Eg heiter Frode");

