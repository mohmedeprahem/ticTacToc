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

    private static bool Checker(char[,] board) {
      bool isWinner = false;
      if ((board[0,0] == board[1,1] && board[1,1] == board[2,2]) || (board[0,2] == board[1,1] && board[1,1] == board[2,0])) {
          return true;
      } 
      
      for (int i = 0; i < 3; i++) {
          if ((board[i,0] == board[i,1] && board[i,1] == board[i,2]) || (board[0,i] == board[1,i] && board[1,i] == board[2,i])) {
              return true;
          }
      }
      return isWinner;
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
        byte player = 1;
        string value;
        int valueAsInt;
        while (counter < 9) {
          // Create ui in console
          DisplalyShape(elementsGame);

          // Check if there is winner
          isWinner = Checker(elementsGame);

          if (isWinner) {
            Console.WriteLine("player {0} is won", player);
            break;
          }

          // Check if the data valid
          Console.WriteLine("Player {0}: your turn", player);
          Console.Write("Choose ur field: ");

          value = Console.ReadLine();

          if (!int.TryParse(value, out valueAsInt)) {
            Console.WriteLine("Invalid input, Enter number between 1 to 9");
            continue;
          }

          if (valueAsInt < 1 || valueAsInt > 9) {
            Console.WriteLine("Invalid input, Enter number between 1 to 9");
            continue;
          }

          bool addValue = false;

          for (int i = 0; i < elementsGame.GetLength(0); i++) {
            for (int j = 0; j < elementsGame.GetLength(1); j++) {
              if (elementsGame[i, j] == value[0]) {
                if (player == 1) {
                  elementsGame[i, j] = 'X';
                  player++;
                } else {
                  elementsGame[i, j] = 'O';
                  player--;
                }
                counter++;
                addValue = true;
                break;
              }
            }
          }

          if (!addValue) {
            Console.WriteLine("this number is already used");
          }
        }

        if (!isWinner) {
          Console.WriteLine("Draw");
        }
      } catch (IOException) {
        Console.WriteLine("Not a valid");
      }
        
    }



  }
}