package operTest_1208;

public class OpTest4 {

	public static void main(String[] args) {
		int num = 99;
		
		// && (and������) 
		// true && true --> true
		// true && false --> false
		// false && true --> false
		// false && false --> false
		// true = 1 false = 0�̶�� �����ϸ��
		System.out.println("and���� : " + 
				(num >= 100 && num <= 200));  // num >= 100 = false    num <= 200 = true  false && true �� �ǹǷ� ����� false�� ��

		
		// || (�� or������)
		// true || true --> true
		// true || false --> true
		// false || true --> true
		// false || false --> false
		System.out.println("or ���� : " + 
				(num >= 100 || num <= 200));  // false || true �� �ǹǷ� ����� true�� ��
		
		// ! (�� not������) ������Ŵ. 
		// ! (true) --> false
		// ! (false) --> true
		System.out.println("not������ : " +
				!(num == 100));
		
		
	}

}
