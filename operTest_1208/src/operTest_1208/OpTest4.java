package operTest_1208;

public class OpTest4 {

	public static void main(String[] args) {
		int num = 99;
		
		// && (and연산자) 
		// true && true --> true
		// true && false --> false
		// false && true --> false
		// false && false --> false
		// true = 1 false = 0이라고 생각하면됨
		System.out.println("and연산 : " + 
				(num >= 100 && num <= 200));  // num >= 100 = false    num <= 200 = true  false && true 가 되므로 결과는 false가 됨

		
		// || (논리 or연산자)
		// true || true --> true
		// true || false --> true
		// false || true --> true
		// false || false --> false
		System.out.println("or 연산 : " + 
				(num >= 100 || num <= 200));  // false || true 가 되므로 결과는 true가 됨
		
		// ! (논리 not연산자) 반전시킴. 
		// ! (true) --> false
		// ! (false) --> true
		System.out.println("not연산자 : " +
				!(num == 100));
		
		
	}

}
