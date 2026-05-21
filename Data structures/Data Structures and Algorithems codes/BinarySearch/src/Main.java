//import java.util.*;
//public static int BinarySearch(int[] numbers, int valueToFind){
//
//    int firstIndex = 0;
//    int lastIndex = numbers.length-1;
//    boolean found = false;
//    int position = -1;
//
//    while(found==false && firstIndex<=lastIndex){
//
//        int middle = (firstIndex+lastIndex)/2;
//
//        if (numbers[middle] == valueToFind){
//            found = true;
//            position = middle;
//        }
//        else if(numbers[middle]>valueToFind){
//            lastIndex = middle-1;
//
//        }
//        else{
//            firstIndex = middle+1;
//        }
//    }
//}
//
//public class Main{
//    public static void main(String[] args){
//        //System.out.println("This is my first java programme");
//        int[] numbers ={10,20,13,24,25,678} ;
//
//        int valueToFind = 20;
//
//        int position = BinarySearch(numbers,valueToFind);
//
//        System.out.println(position);
//    }
//}
