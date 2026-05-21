
public class Main {
    public static void main(String[] args) {
        int[] array={100,2,4,23,67,35,45,67,89};
        int size = array.length - 1;

        for (int j = 0; j<size; j++){
            for (int i=0; i<size; i++){
                if (array[i]>array[i+1]){
                    int swapVariable = array[i];
                    array[i]=array[i+1];
                    array[i+1]=swapVariable;
                }
            }}
        for(int item: array) System.out.println(item);
    }}