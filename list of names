import java.util.*;
public class StudName{
       public static void main(String[] args) { 
              Scanner sc = new Scanner(System.in); 
              String[] names=new String[5];
              for(int i=0;i<names.length;i++){ 
                      System.out.println("Enter Name: "); 
                      names[i]=sc.nextLine();
              }
              String Longestname=names[0]; 
              String Shortestname=names[0]; 
              for(int i=0;i<names.length;i++){
                      if(names[i].length()>Longestname.length()){ 
                              Longestname=names[i];
                      }
                      if(names[i].length()<Shortestname.length()){ 
                              Shortestname=names[i];
                      }
              }
              System.out.println("Names are in Reverse Order:"); 
              for(int i=names.length-1;i>=0;i--){
                      System.out.print(names[i]);
                      if(i>0){
                              System.out.print(",");
                      }
              }
              System.out.println();
              System.out.println("Longest Name is: "+Longestname); 
              System.out.println("Shortest Name: "+Shortestname);
     } 
}
