
public class Yeondong {

	public static void main(String[] args) {
		// IDE�� git�� �����Ͽ� IDE���� �ٷ� commit&push
		System.out.println("�������� ����ϴ� �� ���̾�");
		
		String str = "��������";
		String str1 = "����ϴ�";
		
		System.out.println(str + str1);
		
		String str3 = "Good Morning";
		
		System.out.println("charat : " + str3.charAt(6));
		System.out.println("replace : " + str3.replace("Good" , "a"));
		System.out.println("replace : " + str3.replace("[Good]", "a"));
		System.out.println("replaceall : " + str3.replace("Good" , "a"));
		System.out.println("replaceall : " + str3.replace("[Good]" , "a"));
		
		
		System.out.println("��Ŭ�������� ����� ����ũž ����");
		
		int a = 384;
		int b = 472;
		
		System.out.println("1 : " + a*(b%10));
		System.out.println("2 : " + a*(b%100/10));
		System.out.println("3 : " + a*(b/100));
		System.out.println("4 : " + a*b);
		System.out.println();
		
		
	}

}
