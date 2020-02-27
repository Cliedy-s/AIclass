-- 97�� ���� �ֹ��Ǽ�
SELECT Month(OrderDate) ��, Count(*) �Ǽ� FROM Orders WHERE Year(OrderDate) = 1997 GROUP BY Month(OrderDate) ORDER BY ��;

-- 97�⿡ ���� �ȸ� ��ǰ ����Ʈ 5
SELECT pd.ProductName, tab.ProductID, tab.quan
FROM (
	SELECT TOP(5) od.ProductID, Sum(Quantity) quan 
	FROM Orders o 
		INNER JOIN [Order Details] od ON o.OrderID = od.OrderID 
	WHERE Year(OrderDate) = 1997 
	GROUP BY od.ProductID 
	ORDER BY quan DESC) as tab
JOIN Products pd ON pd.ProductID = tab.ProductID;


-- 97�⿡ top5���� ���� �Ǹŷ�
SELECT od.ProductID, ProductName, SUM(Quantity) qty, Month(OrderDate) orderdate
FROM Orders o 
	INNER JOIN [Order Details] od on o.OrderID = od.OrderID
	INNER JOIN Products p on od.ProductID = p.ProductID
WHERE YEAR(OrderDate) = 1997
	AND od.ProductID IN (SELECT TOP(5) od.ProductID
	FROM Orders o 
		INNER JOIN [Order Details] od ON o.OrderID = od.OrderID 
	WHERE Year(OrderDate) = 1997 
	GROUP BY od.ProductID 
	ORDER BY Sum(Quantity) DESC)
GROUP BY MONTH(OrderDate), od.ProductID, ProductName;

-- pivot
SELECT * FROM (
		SELECT ProductName, SUM(Quantity) qty, Month(OrderDate) orderdate
		FROM Orders o 
			INNER JOIN [Order Details] od on o.OrderID = od.OrderID
			INNER JOIN Products p on od.ProductID = p.ProductID
		WHERE YEAR(OrderDate) = 1997
			AND od.ProductID IN (SELECT TOP(5) od.ProductID
			FROM Orders o 
				INNER JOIN [Order Details] od ON o.OrderID = od.OrderID 
			WHERE Year(OrderDate) = 1997 
			GROUP BY od.ProductID 
			ORDER BY Sum(Quantity) DESC)
		GROUP BY MONTH(OrderDate), od.ProductID, ProductName
		) as t
PIVOT (SUM(qty) FOR orderdate
       IN ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12])
       )
       AS P;

-- nulló�� 1
SELECT ProductName, ISNULL([1], 0) [1], ISNULL([2], 0) [2], ISNULL([3], 0) [3], ISNULL([4], 0) [4], ISNULL([5], 0) [5], ISNULL([6], 0) [6], ISNULL([7], 0) [7], ISNULL([8], 0) [8], ISNULL([9], 0) [9], ISNULL([10], 0) [10], ISNULL([11], 0) [11], ISNULL([12], 0) [12] FROM (
		SELECT ProductName, SUM(Quantity) qty, Month(OrderDate) orderdate
		FROM Orders o 
			INNER JOIN [Order Details] od on o.OrderID = od.OrderID
			INNER JOIN Products p on od.ProductID = p.ProductID
		WHERE YEAR(OrderDate) = 1997
			AND od.ProductID IN (SELECT TOP(5) od.ProductID
			FROM Orders o 
				INNER JOIN [Order Details] od ON o.OrderID = od.OrderID 
			WHERE Year(OrderDate) = 1997 
			GROUP BY od.ProductID 
			ORDER BY Sum(Quantity) DESC)
		GROUP BY MONTH(OrderDate), od.ProductID, ProductName
		) as t
PIVOT (SUM(qty) FOR orderdate
       IN ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12])
       )
       AS P;

-- nulló�� 2
SELECT * FROM
(SELECT ALL_ITEM.ProductID, ISNULL(C.total, 0) OUT_QTY, ALL_ITEM.mon OUT_DT
       FROM (
					SELECT A.ProductID, B.MON
                     FROM
                           (SELECT TOP(5) od.ProductID
								FROM Orders o 
									INNER JOIN [Order Details] od ON o.OrderID = od.OrderID 
								WHERE Year(OrderDate) = 1997 
								GROUP BY od.ProductID 
								ORDER BY Sum(Quantity) DESC) A
                       , (SELECT DISTINCT MONTH(OrderDate) MON FROM Orders) B
					) ALL_ITEM
	   LEFT OUTER JOIN (SELECT od.ProductID, MONTH(o.OrderDate) as mon, sum(Quantity) as total 
						FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID 
						WHERE Year(OrderDate) = 1997 AND od.ProductID IN (SELECT TOP(5) od.ProductID
								FROM Orders o 
									INNER JOIN [Order Details] od ON o.OrderID = od.OrderID 
								WHERE Year(OrderDate) = 1997 
								GROUP BY od.ProductID 
								ORDER BY Sum(Quantity) DESC)
						GROUP BY od.ProductID, MONTH(o.OrderDate)) C
		ON ALL_ITEM.ProductID = C.ProductID AND ALL_ITEM.MON = C.mon) T
PIVOT (SUM(OUT_QTY) FOR OUT_DT
IN ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12])
)
AS P;














