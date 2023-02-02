using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using BOL;

List<Topic> allTopic = new List<Topic>();
allTopic.Add(new Topic { Topicname = "CORE JAVA", Description ="1st Module" ,Faculty = "Bakul" , Location = "PUNE"  });
allTopic.Add(new Topic { Topicname = "DATA STRUCTURE", Description ="2nd Module" ,Faculty = "Trupti" , Location = "PUNE" });
allTopic.Add(new Topic { Topicname = "DATA BASE", Description ="3rd Module" ,Faculty = "Kishori" , Location = "PUNE"  });
allTopic.Add(new Topic { Topicname = "OPERATING SYSTEM", Description ="4th Module" ,Faculty = "Dhanashree" , Location = "PUNE" });
allTopic.Add(new Topic { Topicname = "DOT NET", Description ="5th Module" ,Faculty = "Ravi" , Location = "PUNE"  });
allTopic.Add(new Topic { Topicname = "ADVANCE JAVA", Description ="6th Module" ,Faculty = "Bakul" , Location = "PUNE"  });
allTopic.Add(new Topic { Topicname = "SDM", Description ="7th Module" ,Faculty = "Ravi" , Location = "PUNE"  });
allTopic.Add(new Topic { Topicname = "WEB PROGRAMMING", Description ="8th Module" ,Faculty = "Bakul" , Location = "PUNE"  });




List<Customer> customers = new List<Customer>();
customers.Add(new Customer { Fname = "Shubham", Lname = "Mhaske", Cnum = "7276741200", Location = "Pune", Email = "mhaske1200@gmail.com", Password = "1200" });

string jsonString = JsonSerializer.Serialize(customers);
File.WriteAllText("../customers.json", jsonString);

string jsonString2 = JsonSerializer.Serialize(allTopic);
File.WriteAllText("../trainingtopic.json", jsonString2);
