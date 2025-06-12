using ParProgrammering5_Oppgave1;

HarryPotterCharacter character1 = new("Harry Potter", "Gryffindor");

Console.WriteLine(character1.ToString());

GameMenu store = new();
store.Run(character1);
