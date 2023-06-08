namespace TicTacToc
{
  public class Method
  {

    private static void DisplalyShape(char[,] elementsGame) {
      for(int i = 0; i < elementsGame.GetLength(0); i++) {
        for(int j = 0; j < elementsGame.GetLength(1); j++) {
          if (j == 2) {
            Console.WriteLine("{0} \n----------", elementsGame[i, j]);    
          } else {
            Console.Write("{0} | ", elementsGame[i, j]);
          }
        }
      }
    }
    
    public static void Main()
    {
      try {
        bool isWinner = false;
        int counter = 0;
        char[,] elementsGame = {
          {'1', '2', '3'},
          {'4', '5', '6'},
          {'7', '8', '9'}
        };
        // while (counter < 9) {
        // Create ui in console
        DisplalyShape(elementsGame);

        //   // Check if there is winner
        // }
      } catch (IOException) {
        Console.WriteLine("Not a valid");
      }
        
    }



  }
}