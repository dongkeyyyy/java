import java.util.Scanner;

public class Input2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scan = new Scanner(System.in);
		System.out.println("ù��° ������ �Է�: ");
		int num1 = scan.nextInt();
		System.out.println("�ι�° ������ �Է�: ");
		int num2 = scan.nextInt();
		System.out.println("����° ������ �Է�: ");
		int num3 = scan.nextInt();
		
		int sum = num1 + num2 + num3;
		int ave = sum / 3;
		
		System.out.println("�հ�: " + sum);
		System.out.println("���: " + ave);
	} 

}
