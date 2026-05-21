
class Stack {
    private final int[] stack;
    private int top;
    private final int size;

    public Stack(int size) {
        stack = new int[size];
        this.size = size;
        top = -1;
    }

    public void push(int x) {
        if (top == size - 1) {
            System.out.println("Stack Overflow");
            return;
        }
        stack[++top] = x;
    }

    public int pop() {
        if (top == -1) {
            System.out.println("Stack Underflow");
            return -1;
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

}

public class Main {
    static void main() {

        Stack stackA = new Stack(5);

        stackA.push(1);
        stackA.push(2);
        stackA.push(3);
        stackA.push(4);
        stackA.push(5);
        stackA.push(6);
        stackA.push(7);

        stackA.print();
        Stack stackB = stackA.copy();
        stackB.print();

    }}