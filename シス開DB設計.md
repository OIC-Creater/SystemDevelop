# 従業員ファイル

## employees(従業員表)

|colmun|type|option|
|---|---|---|
|emp_id|AutoNumber|prime,required|
|employee_name|Text|required|
|authority_level|Number|required|
|password|Text|required,桁数不明|
|now_working|Yes/No|required|

# 店舗ファイル

## shops(店舗表)

|colmun|type|option|
|---|---|---|
|shop_id|Text|prime,7桁|
|shop_name|Text|required|
|shop_address|Text|required|
|shop_tel|Number|required|
|now_transaction|Yes/No|required|

# メーカファイル

## manufacturers(メーカ表)

|colmun|type|option|
|---|---|---|
|manufacturer_id|Text|prime,6桁|
|manufacturer_name|Text|required|
|manufacturer_tel|Number|required|
|manufacturer_fax|Number|required|
|now_manufacturing|Yes/No|required|

# 営業所ファイル

## salesoffices(営業所表)

|colmun|type|option|
|---|---|---|
|salesoffice_id|AutoNumber|prime|
|salesoffice_name|Text|required|
|salesoffice_tel|Number|required|
|responsible_employee|Number|required,3桁|
|now_salse|Yes/No|required|

# 商品ファイル

## products(商品表)

|colmun|type|option|
|---|---|---|
|product_code|Text|prime,11桁|
|products_name|Text|required|
|price|Number|required|
|manufacturing_id|Text|6桁|
|now_sale|Yes/No|required|

## product_arrivalsettings(定量発注点表)

|colmun|type|option|
|---|---|---|
|product_code|Text|prime,11桁|
|autoorder_line|Number|required|

## product_arrivalamount(定量発注量表)

|colmun|type|option|
|---|---|---|
|product_code|Text|prime,11桁|
|order_per_carton|Number|required|

## stocks(在庫表)

|colmun|type|option|
|---|---|---|
|product_code|Text|prime,11桁|
|stock|Number|required|

# 受注ファイル

## orders(受注表)

|colmun|type|option|
|---|---|---|
|id|AutoNumber|prime|
|order_id|Number|required|
|product_code|Text|required,11桁|
|order_amount|Number|required|
|datetime|ShortDate|required|

## orders_from(受注営業所、ショップ表)

|colmun|type|option|
|---|---|---|
|id|AutoNumber|prime|
|order_id|Number|required|
|salesoffice_id|Number|required|
|shop_id|Text|required,7桁|
|is_completed|Yes/No|required|

## receipts(受領書表)

|colmun|type|option|
|---|---|---|
|id|AutoNumber|prime|
|order_id|Number|required|
|is_acceptance|Yes/No|required|
|acceptance_date|ShortDate||

# 発注ファイル

## manufacturer_orders(発注表)

|colmun|type|option|
|---|---|---|
|id|AutoNumber|prime|
|manufacturer_order_id|Number|required|
|product_code|Text|prime,11桁|
|manufacturer_order_amount|Number|required|

## products_receiving(倉庫入荷表)

|colmun|type|option|
|---|---|---|
|manufacturer_order_id|Number|prime|
|is_arrival|Yes/No|required|

# ログファイル

## logs(ログ表)

|colmun|type|option|
|---|---|---|
|log_id|AutoNumber|prime,required|
|who_operation|Number|required|
|processing_division|Number||
|processing_content|Text||
|who_manufacturers|Text|6桁|
|who_shop|Text|7桁|
|who_salesoffice|Number||
|timestamp|ShortDate|required|
