public class Main {
    public static void main(String[] args) {
        int[] array={10,20,4,23,67,35,45,67,89};

        int n = array.length;

        for (int j = 0; j<n-1;j++){

            int smallest = j;

            for(int i=j+1;i<n;i++){
                if(array[i]<array[smallest]){
                    smallest = i;
                }}
            int temp = array[smallest];
            array[smallest] = array[j];
            array[j] = temp;
        }
        for(int item: array){
            System.out.println(item);
        }}}


