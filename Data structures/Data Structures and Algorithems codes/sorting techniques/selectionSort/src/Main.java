public class Main {
    public static void main(String[] args) {
        int[] array={10,20,4,23,67,35,45,67,89};

        int n = array.length;

        for (int i = 1; i<n;i++){
            int current = array[i];
            int j=i;
            while(j>0 && array[j-1]>current){
                array[j]=array[j-1];
                j=j-1;
            }
            array[j]=current;
        }
        for(int item: array){
            System.out.println(item);
        }}}