
class Stack {
    private final String[] stack;
    private int top;
    private final int size;

    public Stack(int size) {
        stack = new String[size];
        this.size = size;
        top = -1;
    }

    public void push(String x) {
        if (top == size - 1) {
            System.out.println("Stack Overflow");
            return;
        }
        stack[++top] = x;
    }

    public String pop() {
        if (top == -1) {
            System.out.println("Stack Underflow");
            return String.valueOf(-1);
        }
        return stack[top--];
    }

    public void print() {
        for (int i = top; i >= 0; i--) {
            System.out.println(stack[i]);
        }
    }

    public Stack copy() {
        Stack tempStack = new Stack(size);
        Stack outStack = new Stack(size);

        for (int i = top; i >= 0; i--) {
            tempStack.push((stack[i]));
        }

        while (tempStack.top != -1) {
            outStack.push(tempStack.pop());
        }

        return outStack;
    }
    public Stack stringToStack(String word){
        Stack tempStack = new Stack(word.length());
        for (int i = 0; i < word.length(); i++) {
            tempStack.push(String.valueOf(word.charAt(i)));
        }
        return tempStack;
    }
    public Stack reverse(Stack CheckStack){
 Stack ReverseStack = new Stack(size);

        for (int i = top; i >= 0; i--) {
            ReverseStack.push((stack[i]));
        }
        return ReverseStack;
    }

    public void checkPalindrome(String word){
        Stack OriginalStack = stringToStack(word);
        Stack ReverseStack = reverse(OriginalStack);
        boolean isPalindrome=false;

        for (int i = size; i>0;i--){
            if (OriginalStack.equals(ReverseStack)) {
                isPalindrome = true;

                break;
            }
        }
        if (isPalindrome){
            System.out.println("a palindrome!!");
        }else{
            System.out.println("not a palindrome");
        }
    }
}

public class Main {
    public static void main(String[] args) {

        Stack stackA = new Stack(5);

        stackA.checkPalindrome("madam");
        stackA.checkPalindrome("hello");

    }}