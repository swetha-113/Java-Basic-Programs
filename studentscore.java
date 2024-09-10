import java.util.*;
public class Studscore{
       public static void main(String[] args){
              Scanner numbers= new Scanner(System.in);
              int[] score = new int[5];
              for(int i=0;i<score.length;i++)
                      score[i]=numbers.nextInt();
              int sum=0;
              float avg;
              for(int i=0;i<score.length;i++)
                      sum=sum+score[i];
              avg=sum/score.length;
              System.out.print("Scores:");
              for(int i=0;i<score.length;i++)
                      System.out.print(score[i]+" ");
              System.out.println();
              System.out.println("Average Score:"+avg); 
              Arrays.sort(score);
              System.out.println("Highest Score:"+score[score.length-1]);
              System.out.println("Lowest Score:"+score[0]);   
      }
}

