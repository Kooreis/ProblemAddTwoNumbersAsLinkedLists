Here is a Java console application that solves the problem:

```java
import java.util.LinkedList;

public class Main {
    public static void main(String[] args) {
        LinkedList<Integer> num1 = new LinkedList<>();
        num1.add(2);
        num1.add(4);
        num1.add(3);

        LinkedList<Integer> num2 = new LinkedList<>();
        num2.add(5);
        num2.add(6);
        num2.add(4);

        LinkedList<Integer> result = addTwoNumbers(num1, num2);

        for (int num : result) {
            System.out.print(num);
        }
    }

    public static LinkedList<Integer> addTwoNumbers(LinkedList<Integer> l1, LinkedList<Integer> l2) {
        LinkedList<Integer> result = new LinkedList<>();
        int carry = 0;
        while (!l1.isEmpty() || !l2.isEmpty()) {
            int sum = carry;
            if (!l1.isEmpty()) sum += l1.removeLast();
            if (!l2.isEmpty()) sum += l2.removeLast();
            result.addFirst(sum % 10);
            carry = sum / 10;
        }
        if (carry != 0) result.addFirst(carry);
        return result;
    }
}
```

This program creates two linked lists, `num1` and `num2`, representing the numbers 342 and 465 respectively. It then calls the `addTwoNumbers` function, which adds the numbers together and returns the result as a linked list. The result is then printed to the console.