¦M
ZC:\revature\project0\daniel-project0\redrobin\RedRobin.Library\Interfaces\IRedRobinRepo.cs
	namespace 	
RedRobin
 
. 
Library 
. 

Interfaces %
{ 
public 

	interface 
IRedRobinRepo "
{		 
IEnumerable 
< 

Restaurant 
> 
GetAllRestaurants  1
(1 2
)2 3
;3 4
void 
AddRestaurant 
( 

Restaurant %

restaurant& 0
)0 1
;1 2

Restaurant 
GetRestaurantById $
($ %
int% (
resID) .
). /
;/ 0
void 
UpdateRestaurant 
( 

Restaurant (

restaurant) 3
)3 4
;4 5
void 
DeleteRestaurant 
( 
int !
restaurantId" .
). /
;/ 0
void %
DeleteRestaurantInRestIng &
(& '
int' *
restaurantId+ 7
)7 8
;8 9
void %
DeleteRestaurantInRestPro &
(& '
int' *
restaurantId+ 7
)7 8
;8 9
void $
DeleteRestaurantInOrders %
(% &
int& )
restaurantId* 6
)6 7
;7 8
IEnumerable 
< 
	Customers 
> 
GetCustomer *
(* +
string+ 1
custName2 :
): ;
;; <
void 
AddCustomer 
( 
	Customers "

restaurant# -
)- .
;. /
IEnumerable 
< 
	Customers 
> !
GetOrdersfromCustomer 4
(4 5
int5 8
orderID9 @
)@ A
;A B
IEnumerable 
< 
	Customers 
> 
GetAllCustomers .
(. /
)/ 0
;0 1
	Customers 
GetCustomerById !
(! "
int" %
custID& ,
), -
;- .
Models!! 
.!! 
	Customers!! 
GetLastCust!! $
(!!$ %
)!!% &
;!!& '
IEnumerable"" 
<"" 
Models"" 
."" 
	Customers"" $
>""$ %
GetCustomerByName""& 7
(""7 8
string""8 >
name""? C
)""C D
;""D E
void%% 
AddIngredient%% 
(%%  
IngredientsInventory%% /

ingredient%%0 :
)%%: ;
;%%; < 
IngredientsInventory&& 
GetIngredientById&& .
(&&. /
int&&/ 2
ingID&&3 8
)&&8 9
;&&9 :
IEnumerable'' 
<''  
IngredientsInventory'' (
>''( )

GetLastIng''* 4
(''4 5
)''5 6
;''6 7
IEnumerable** 
<** 
RestIng** 
>** &
GetAllRestautantIngredient** 7
(**7 8
int**8 ;
resID**< A
,**A B
int**C F
ingID**G L
)**L M
;**M N
IEnumerable++ 
<++ 
RestIng++ 
>++ ,
 GetAllRestautantIngredientToSubs++ =
(++= >
int++> A
resID++B G
)++G H
;++H I
IEnumerable,, 
<,,  
IngredientsInventory,, (
>,,( )#
GetRestautantIngredient,,* A
(,,A B
int,,B E
resID,,F K
),,K L
;,,L M
void-- #
AddRestaurantIngredient-- $
(--$ %
RestIng--% ,
restIngredient--- ;
)--; <
;--< =
void.. &
UpdateRestaurantIngredient.. '
(..' (
RestIng..( /
restIngredient..0 >
)..> ?
;..? @
IEnumerable// 
<// 
RestIng// 
>// 
GetAllIngredientsDB// 0
(//0 1
int//1 4
ResID//5 :
)//: ;
;//; <
IEnumerable00 
<00  
IngredientsInventory00 (
>00( )
GetAllIngredients00* ;
(00; <
int00< ?
ingID00@ E
)00E F
;00F G
RestIng11 #
GetIngredientByIdIngRes11 '
(11' (
int11( +
ingID11, 1
)111 2
;112 3
IEnumerable55 
<55 
Products55 
>55 
GetAllProducts55 ,
(55, -
int55- 0
restID551 7
)557 8
;558 9
void66 

AddProduct66 
(66 
Products66  
burger66! '
)66' (
;66( )
IEnumerable77 
<77 
Products77 
>77 
GetAllProductsDB77 .
(77. /
)77/ 0
;770 1
Products88 
GetProductById88 
(88  
int88  #
proID88$ )
)88) *
;88* +
IEnumerable99 
<99 
Products99 
>99 

GetLastPro99 (
(99( )
)99) *
;99* +
void:: 
UpdateProduct:: 
(:: 
Products:: #
product::$ +
)::+ ,
;::, -
IEnumerable;; 
<;; 
Models;; 
.;; 
Products;; #
>;;# $
GetProductRevenue;;% 6
(;;6 7
int;;7 :
proID;;; @
);;@ A
;;;A B
IEnumerable>> 
<>>  
IngredientsInventory>> (
>>>( )$
GetAllIngredientProducts>>* B
(>>B C
int>>C F
proID>>G L
)>>L M
;>>M N
IEnumerable?? 
<?? 
IngPro?? 
>?? *
GetAllIngredientProductsToSubs?? :
(??: ;
int??; >
proID??? D
)??D E
;??E F
voidAA  
AddIngredientProductAA !
(AA! "
IngProAA" (

ingProductAA) 3
)AA3 4
;AA4 5
voidBB #
UpdateIngredientProductBB $
(BB$ %
IngProBB% +

ingProductBB, 6
)BB6 7
;BB7 8
voidEE  
AddRestaurantProductEE !
(EE! "
ResProEE" (
resProductsEE) 4
)EE4 5
;EE5 6
IEnumerableFF 
<FF 
ResProFF 
>FF 
GetAllProductsDBFF ,
(FF, -
intFF- 0
ResIDFF1 6
)FF6 7
;FF7 8
voidII 
	AddOrdersII 
(II 
OrdersII 
ordersII $
)II$ %
;II% &
IEnumerableJJ 
<JJ 
OrdersJJ 
>JJ #
GetOrdersfromRestaurantJJ 3
(JJ3 4
intJJ4 7
RestIDJJ8 >
)JJ> ?
;JJ? @
IEnumerableKK 
<KK 
OrdersKK 
>KK 
GetOrdersCustomerKK -
(KK- .
intKK. 1
custIDKK2 8
)KK8 9
;KK9 :
IEnumerableLL 
<LL 
OrdersLL 
>LL +
GetOrdersfromRestaurantCheapestLL ;
(LL; <
intLL< ?
restIDLL@ F
)LLF G
;LLG H
IEnumerableMM 
<MM 
OrdersMM 
>MM ,
 GetOrdersfromRestaurantExpensiveMM <
(MM< =
intMM= @
restIDMMA G
)MMG H
;MMH I
IEnumerableNN 
<NN 
OrdersNN 
>NN +
GetOrdersfromRestaurantEarliestNN ;
(NN; <
intNN< ?
restIDNN@ F
)NNF G
;NNG H
IEnumerableOO 
<OO 
OrdersOO 
>OO )
GetOrdersfromRestaurantLatestOO 9
(OO9 :
intOO: =
restIDOO> D
)OOD E
;OOE F
IEnumerablePP 
<PP 
OrdersPP 
>PP 
GetOrdersRevenueDayPP /
(PP/ 0
intPP0 3
restIDPP4 :
,PP: ;
DateTimePP< D
datePPE I
)PPI J
;PPJ K
IEnumerableQQ 
<QQ 
OrdersQQ 
>QQ !
GetOrdersRevenueMonthQQ 1
(QQ1 2
intQQ2 5
restIDQQ6 <
,QQ< =
DateTimeQQ> F
dateQQG K
)QQK L
;QQL M
IEnumerableRR 
<RR 
OrdersRR 
>RR  
GetOrdersRevenueYearRR 0
(RR0 1
intRR1 4
restIDRR5 ;
,RR; <
DateTimeRR= E
dateRRF J
)RRJ K
;RRK L
IEnumerableSS 
<SS 
OrdersSS 
>SS 
GetAllOrdersDBSS *
(SS* +
)SS+ ,
;SS, -
IEnumerableTT 
<TT 
OrdersTT 
>TT 

GetLastOrdTT &
(TT& '
)TT' (
;TT( )
voidUU 
UpdateOrderUU 
(UU 
OrdersUU 
orderUU  %
)UU% &
;UU& '
OrdersVV 
GetOrdersByIdVV 
(VV 
intVV  
ordIDVV! &
)VV& '
;VV' (
voidYY 
AddOrderProductYY 
(YY 
OrdProYY #
ordProYY$ *
)YY* +
;YY+ ,
IEnumerableZZ 
<ZZ 
ProductsZZ 
>ZZ 
GetAllOrderProductsZZ 1
(ZZ1 2
intZZ2 5
orderIDZZ6 =
)ZZ= >
;ZZ> ?
IEnumerable[[ 
<[[ 
OrdPro[[ 
>[[ 
GetCountProducts[[ ,
([[, -
int[[- 0
proID[[1 6
)[[6 7
;[[7 8
void]] 
Save]] 
(]] 
)]] 
;]] 
}^^ 
}__ ˆ
RC:\revature\project0\daniel-project0\redrobin\RedRobin.Library\Models\Customers.cs
	namespace 	
RedRobin
 
. 
Library 
. 
Models !
{ 
public 

class 
	Customers 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
private

 
string

 
_name

 
;

 
public 
string 
Name 
{ 	
get 
=> 
_name 
; 
set 
{ 
if 
( 
value 
. 
Length  
==! #
$num$ %
)% &
{ 
throw 
new 
ArgumentException /
(/ 0
$str0 M
)M N
;N O
} 
_name 
= 
value 
; 
} 
} 	
private 
string 
_phone 
; 
public 
string 
Phone 
{ 	
get 
=> 
_phone 
; 
set 
{ 
var   
match   
=   
Regex   !
.  ! "
Match  " '
(  ' (
value  ( -
,  - .
$str  / Q
)  Q R
;  R S
if!! 
(!! 
!!! 
match!! 
.!! 
Success!! "
)!!" #
{"" 
throw## 
new## 
ArgumentException## /
(##/ 0
$str##0 \
)##\ ]
;##] ^
}$$ 
_phone%% 
=%% 
value%% 
;%% 
}&& 
}'' 	
}(( 
})) ¤
OC:\revature\project0\daniel-project0\redrobin\RedRobin.Library\Models\IngPro.cs
	namespace 	
RedRobin
 
. 
Library 
. 
Models !
{ 
public 

class 
IngPro 
{ 
public		 
int		 
ingProID		 
{		 
get		 !
;		! "
set		# &
;		& '
}		( )
public

 
int

 
ingredientId

 
{

  !
get

" %
;

% &
set

' *
;

* +
}

, -
public 
int 
	productId 
{ 
get "
;" #
set$ '
;' (
}) *
public 
decimal 
	ingProQty  
{! "
get# &
;& '
set( +
;+ ,
}- .
} 
} ý	
]C:\revature\project0\daniel-project0\redrobin\RedRobin.Library\Models\IngredientsInventory.cs
	namespace 	
RedRobin
 
. 
Library 
. 
Models !
{ 
public 

class  
IngredientsInventory %
{		 
public

 
int

 
Id

 
{

 
get

 
;

 
set

  
;

  !
}

" #
private 
string 
_name 
; 
public 
string 
Name 
{ 	
get 
=> 
_name 
; 
set 
{ 
if 
( 
value 
. 
Length  
==! #
$num$ %
)% &
{ 
throw 
new 
ArgumentException /
(/ 0
$str0 Z
)Z [
;[ \
} 
_name 
= 
value 
; 
} 
} 	
public 
decimal 
Cost 
{ 
get !
;! "
set# &
;& '
}( )
} 
} š
OC:\revature\project0\daniel-project0\redrobin\RedRobin.Library\Models\Orders.cs
	namespace 	
RedRobin
 
. 
Library 
. 
Models !
{ 
public 

class 
Orders 
{ 
public		 
int		 
Id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
public 
int 
	cutomerID 
{ 
get "
;" #
set$ '
;' (
}) *
public 
int 
restaurantID 
{  !
get" %
;% &
set' *
;* +
}, -
public 
DateTime 
	orderDate !
{" #
get$ '
;' (
set) ,
;, -
}. /
publicEE 
decimalEE 
	CostTotalEE  
{EE! "
getEE# &
;EE& '
setEE( +
;EE+ ,
}EE- .
publicFF 
ListFF 
<FF 
OrdProFF 
>FF 
ProductsFF $
{FF% &
getFF' *
;FF* +
setFF, /
;FF/ 0
}FF1 2
=FF3 4
newFF5 8
ListFF9 =
<FF= >
OrdProFF> D
>FFD E
(FFE F
)FFF G
;FFG H
}TT 
}UU 
OC:\revature\project0\daniel-project0\redrobin\RedRobin.Library\Models\OrdPro.cs
	namespace 	
RedRobin
 
. 
Library 
. 
Models !
{ 
public 

class 
OrdPro 
{ 
public		 
int		 
ordProID		 
{		 
get		 !
;		! "
set		# &
;		& '
}		( )
public

 
int

 
orderId

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
public 
int 
	productId 
{ 
get "
;" #
set$ '
;' (
}) *
} 
} ù
QC:\revature\project0\daniel-project0\redrobin\RedRobin.Library\Models\Products.cs
	namespace 	
RedRobin
 
. 
Library 
. 
Models !
{ 
public 

class 
Products 
{ 
public		 
int		 
Id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
public 
string 
Type 
{ 
get  
;  !
set" %
;% &
}' (
private 
string 
_name 
; 
public 
string 
Name 
{ 	
get 
=> 
_name 
; 
set 
{ 
if 
( 
value 
. 
Length  
==! #
$num$ %
)% &
{ 
throw 
new 
ArgumentException /
(/ 0
$str0 V
)V W
;W X
} 
_name 
= 
value 
; 
} 
} 	
public 
List 
<  
IngredientsInventory (
>( )
Ingredients* 5
{6 7
get8 ;
;; <
set= @
;@ A
}B C
=D E
newF I
ListJ N
<N O 
IngredientsInventoryO c
>c d
(d e
)e f
;f g
public 
decimal 
Cost 
{ 
get !
;! "
set# &
;& '
}( )
}22 
}33 †
OC:\revature\project0\daniel-project0\redrobin\RedRobin.Library\Models\ResPro.cs
	namespace 	
RedRobin
 
. 
Library 
. 
Models !
{ 
public 

class 
ResPro 
{ 
public		 
int		 
resProID		 
{		 
get		 !
;		! "
set		# &
;		& '
}		( )
public

 
int

 
	productId

 
{

 
get

 "
;

" #
set

$ '
;

' (
}

) *
public 
int 
restaurantId 
{  !
get" %
;% &
set' *
;* +
}, -
} 
} ¢
SC:\revature\project0\daniel-project0\redrobin\RedRobin.Library\Models\Restaurant.cs
	namespace 	
RedRobin
 
. 
Library 
. 
Models !
{ 
[ 

JsonObject 
( 
Title 
= 
$str $
)$ %
]% &
public 

class 

Restaurant 
{		 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
private 
string 
	_location  
;  !
public 
string 
Location 
{ 	
get 
=> 
	_location 
; 
set 
{ 
if 
( 
value 
. 
Length  
==! #
$num$ %
)% &
{ 
throw 
new 
ArgumentException /
(/ 0
$str0 L
)L M
;M N
} 
	_location 
= 
value !
;! "
} 
} 	
private 
string 
_phone 
; 
public 
string 
Phone 
{   	
get!! 
=>!! 
_phone!! 
;!! 
set"" 
{## 
var$$ 
match$$ 
=$$ 
Regex$$ !
.$$! "
Match$$" '
($$' (
value$$( -
,$$- .
$str$$/ Q
)$$Q R
;$$R S
if%% 
(%% 
!%% 
match%% 
.%% 
Success%% "
)%%" #
{&& 
throw'' 
new'' 
ArgumentException'' /
(''/ 0
$str''0 \
)''\ ]
;''] ^
}(( 
_phone)) 
=)) 
value)) 
;)) 
}** 
}++ 	
},, 
}-- ©
PC:\revature\project0\daniel-project0\redrobin\RedRobin.Library\Models\RestIng.cs
	namespace 	
RedRobin
 
. 
Library 
. 
Models !
{ 
public 

class 
RestIng 
{ 
public		 
int		 
resIngID		 
{		 
get		 !
;		! "
set		# &
;		& '
}		( )
public

 
int

 
ingredientId

 
{

  !
get

" %
;

% &
set

' *
;

* +
}

, -
public 
int 
restaurantId 
{  !
get" %
;% &
set' *
;* +
}, -
public 
decimal 
	resIngQty  
{! "
get# &
;& '
set( +
;+ ,
}- .
} 
} Ì
UC:\revature\project0\daniel-project0\redrobin\RedRobin.Library\SecretConfiguration.cs
	namespace 	
RedRobin
 
. 
Library 
{ 
public 

static 
class 
SecretConfiguration +
{ 
public			 
static		 
string		 
ConnectionString		 .
=		/ 0
$str		1 c
+		d e
$str

 (
+

) *
$str *
++ ,
$str "
+# $
$str $
+% &
$str -
+. /
$str 
+ 
$str +
+, -
$str $
;$ %
} 
} 