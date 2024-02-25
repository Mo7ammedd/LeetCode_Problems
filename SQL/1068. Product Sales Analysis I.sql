select product_name , year ,price 
from Sales s left outer join Product  p
  on p.product_id = s.product_id 