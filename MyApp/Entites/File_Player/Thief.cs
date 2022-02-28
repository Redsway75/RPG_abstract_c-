namespace MyApp
{
    public class Thief: Player
    {
         public override void Attack(Enemy monster){
            if(monster.HP>0){
            Console.WriteLine(this.Name+" Desferiu um ataque com adagas no " +monster.Name);
             monster.HP = monster.HP - 15;
             this.MagicPoints=this.MagicPoints+15;
             Console.WriteLine($"{monster.Name} tem {monster.HP} de vida");
             Console.WriteLine($"{this.Name}: +15 de mana");
             Console.WriteLine("");
                if(monster.HP <= 0){Console.WriteLine(this.Name+"Matou "+monster.Name);
                  this.MagicPoints=this.MagicPoints+25;
                  this.Level=this.Level+1;
                  Console.WriteLine($"{this.Name}: +25 de mana");
                  Console.WriteLine($"{this.Name} subiu de nivel! level atual: {this.Level}!");
                  Console.WriteLine("");
                }
            }
             else{Console.WriteLine("O inimigo já está eliminado");}
         }
         
         public override void SpecialAttack(Enemy monster){
            if(this.MagicPoints >= 35){
             if(monster.HP != 0){
             Console.WriteLine(this.Name+" lançou 3 kunais no "+monster.Name);
             monster.HP = monster.HP - 35;
             this.MagicPoints=this.MagicPoints-35;
             Console.WriteLine($"{monster.Name} tem {monster.HP} de vida");
             Console.WriteLine($"{this.Name}: -35 de mana");
             Console.WriteLine("");
                if(monster.HP <= 0){
                    Console.WriteLine(this.Name+"Matou "+monster.Name);
                    this.Level=this.Level+1;
                    this.MagicPoints=this.MagicPoints+40;
                    Console.WriteLine($"{this.Name}: +40 de mana");
                    Console.WriteLine($"{this.Name} subiu de nivel! level atual: {this.Level}!");
                    Console.WriteLine("");
                }
             }
             else{Console.WriteLine("O inimigo já está eliminado");}
            }
            else{Console.WriteLine("Mana insuficiente para desferir o ataque!");}
         }
         public override void skill(Enemy monster){
             if(this.MagicPoints >= 45){
              Console.WriteLine($"{this.Name} atordou e roubou {monster.Coin-100} de dinheiro de {monster.Name}");
              monster.Coin = monster.Coin-100;
              monster.HP = monster.HP-25;
              this.Coin = this.Coin+100;
              this.MagicPoints=this.MagicPoints - 45;
              Console.WriteLine($"{monster.Name} está com {monster.HP} de vida agora!");
              Console.WriteLine($"{this.Name}: -45 de mana");
              Console.WriteLine("");
         }
            else{Console.WriteLine("Mana insuficiente para desferir o ataque!");}
         }
         public override void Defend(Enemy monster){
            if(this.MagicPoints>=35){
               Console.WriteLine($"{this.Name} se defendeu desviando dos ataques de {monster.Name}");
               this.MagicPoints=this.MagicPoints-35;
               Console.WriteLine($"{this.Name}: -35 de mana");
               Console.WriteLine("");
         }
            else{Console.WriteLine("Mana insuficiente para se defender!");}
         }
    }    
}