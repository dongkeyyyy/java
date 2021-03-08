package jdbc0226;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class JdbcTest {
	static Connection con;
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "mydb";
	
	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	static String dbUrl = "jdbc:mysql://localhost/" + DBNAME +"?autoReconnect=true&serverTimezone=UTC";
	

	public static void main(String[] args) {
		connectDB();
//		closeDB();
	}
	
	public static void connectDB() {
		try {
			Class.forName(jdbcDriver).newInstance();
			con = DriverManager.getConnection(dbUrl,
					USER_ID, USER_PW);
			if (con != null) {
				System.out.println("DB 접속");
			}
			
		} catch (InstantiationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IllegalAccessException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public static void closeDB() {
		try {
			con.close();
			System.out.println("DB 종료");
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

}
