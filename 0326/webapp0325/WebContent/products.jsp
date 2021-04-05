<%@page import="com.mk.web.dto.Product"%>
<%@page import="java.util.ArrayList"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<jsp:useBean id="productDAO" class="com.mk.web.dao.ProductRepo" scope="session" /> 
<!-- id="productDAO" = productDAO를 불러와 객체 생성이 가능 -->   

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<link rel="stylesheet" 
	href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"> 
<title>제품 목록</title>
</head>
<body>
	<jsp:include page="menu.jsp" />
	<div class="jumbotron">
		<div class="container">
			<h1 class="display-3">제품 리스트</h1>
		</div>
	</div>
	<%
	ArrayList<Product> list = productDAO.getAllProduct();
	%>
	<div class="contanier">
		<div class="row" align="center">
			<%
			for (int i=0; i<list.size(); i++) {
				Product product = list.get(i);
			%>
			<c:set var="price" value="<%=product.getUnitPrice()%>" />
			<div class="col-md-4">
				<h3><%=product.getPname()%></h3>
				<p><%=product.getDescription()%>
				<p><fmt:setLocale value="ko_KR"/>
				   <fmt:formatNumber type="currency" value="${price}" />원
				<p><a href="product_detail.jsp?id=<%=product.getProductId()%>"
					class="btn btn-secondary" role="button">상세 정보 &raquo;</a>
			</div>
			<% } %>
		</div>
		<hr>
	</div>
	<jsp:include page="footer.jsp" />
</body>
</html>









