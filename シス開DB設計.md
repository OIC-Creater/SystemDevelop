# employees

|colmun|tyoe|option|
|---|---|---|
|emp_id|AutoNumber|prime,required|
|name|Text|required|
|authority_level|Number|required,3桁|
|password|Text|?|
|now_working|Yes/No|required|


# shops

|colmun|type|option|
|---|---|---|
|shop_id|Text|prime,7桁|
|name|Text|required|
|address|Text|required|
|phone_number|Number|required|
|now_transaction|Yes/No|required|

# manufacturers

|colmun|type|option|
|---|---|---|
|manufacturer_id|Text|prime,6桁|
|name|Text|required|
|now_manufacturing|Yes/No|required|

# products

|colmun|type|option|
|---|---|---|
|product_code|Text|prime,11桁|
|name|Text|required|
|price|Number|required|
|manufacturing_id|Text|6桁|
|now_sale|Yes/No|required|

# product_arrivalsettings

|colmun|type|option|
|---|---|---|
|product_code|Text|prime,11桁|
|autoorder_line|Number|required|

# product_arrivalamount

|colmun|type|option|
|---|---|---|
|product_code|Text|prime,桁|
|//発注入り数的な英語|Number|required|

# logs
?

# orders

|colmun|type|option|
|---|---|---|
|order_id|AutoNumber|prime|
|product_code|Text|required,桁|
|order_amount|Number|required|
|salesoffice_id|Number|required|
||||

# stocks

|colmun|type|option|
|---|---|---|
|product_code|Text|prime,桁|
|stock|Number|required|

# receive_orders

# salesoffices

|colmun|type|option|
|---|---|---|
|salesoffice_id|AutoNumber|prime|
//todo addthis

