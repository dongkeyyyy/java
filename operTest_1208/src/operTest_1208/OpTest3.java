package operTest_1208;

public class OpTest3 {

	public static void main(String[] args) {
		// 논리 연산자
		// 제어문(if)에서 많이 활용.
		int num1 = 100, num2 = 200;
				
		// == 같다? (num1 != num2) num1과 num2가 같냐?
		System.out.println("== 연산자 : " + (num1 == num2));
		
		// != 다르다? (num1 != num2) num1과 num2가 다르냐?
		System.out.println("!= 연산자 : " + (num1 != num2));
		
		// 대,소 비교 num1이 num2보다 크냐?
		System.out.println("> 연산자 : " +  (num1 > num2));
		System.out.println("> 연산자 : " +  (num1 < num2));
		
		// >크다?
		System.out.println("> 연산자 : " +  (num1 > num2));
		// <작다?
		System.out.println("< 연산자 : " +  (num1 < num2));
		// 크거나 같다  (이상)
		System.out.println(">= 연산자 : " +  (num1 >= num2));
		// 작거나 같다  (이하)
		System.out.println("<= 연산자 : " +  (num1 <= num2));

	}

}
