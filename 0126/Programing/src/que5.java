import java.util.Scanner;

public class que5 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("영어 단어를 입력하세요");
		String pass = s.next();
		char a[] = new char[pass.length()];
		for (int i = 0; i < a.length; i++) {
			a[i] = pass.charAt(i);
		}
		char eng[] = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
				't', 'u', 'v', 'w', 'x' };
		char kor[] = { 'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 'ㅂ', 'ㅅ', 'ㅇ', 'ㅈ', 'ㅊ', 'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ', 'ㅏ', 'ㅑ', 'ㅓ', 'ㅕ', 'ㅗ',
				'ㅛ', 'ㅜ', 'ㅠ', 'ㅡ', 'ㅣ' };

		for (int i = 0; i < a.length; i++) {
			for (int j = 0; j < kor.length; j++) {
				if (a[i] == eng[j]) {
					System.out.println(kor[j]);
					
					
					
					break;
				}
			}
		}
	}
}