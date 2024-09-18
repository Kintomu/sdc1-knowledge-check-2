using sdc1_knowledge_check_2;

Console.WriteLine("How many Fire spells do you want to add? ");
var numberOfSpells = int.Parse(Console.ReadLine());

var spellList = new List<FireSpell>();
for (int i = 0; i < numberOfSpells; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var fireSpell = new FireSpell();

    Console.WriteLine("Enter the name of the Spell ");
    fireSpell.Name = Console.ReadLine();

    Console.WriteLine("Enter the Damage of the Spell ");
    fireSpell.Damage = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter how much damage over time it will inflict ");
    fireSpell.DoT = int.Parse(Console.ReadLine());

    spellList.Add(fireSpell);
}

foreach (var spell in spellList)
{ 
    Console.WriteLine("Spell Name: " + spell.Name); 
    Console.WriteLine("Spell Damage: " + spell.Damage.ToString());
    Console.WriteLine("Spell Damage Over Time: " + spell.DoT.ToString());
}

Console.ReadLine();
// Print out the list of records using Console.WriteLine()