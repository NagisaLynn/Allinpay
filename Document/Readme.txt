Developer link => https://www.allinpay.sg/
Refer attached PDF file for more details.

2. API Interface Call
	Recall scenario：Provide for remote device (PC/PAD), call through remote HTTPinterface
	HTTP/HTTPS Request method: Request needs to be URL encoded。
	·Character set：UTF-8 Coding
	·Call method：http://YOUR_POS_IP:9801/trans
	YOUR_POS_IP is the local IP address of the Allinpay smart terminal。

2.1 Request Parameters Example
	Parameters Required instruction
	BUSINESS_ID YES business type
	AMOUNT YES
	Receipt amount (12 digits, cent as a unit)

2.2 Return Example
	
2.3 Field Specification
	1 Amount: 12-digit number, cent as unit, complete the amount by adding 0 on left if the digit numbers are insufficient.
	1 Voucher number: 6-digit number, complete it by adding 0 on left if the digit numbers are insufficient.
	1 Authorization code: 6-digit number, complete it by adding 0 on left if the digit numbers are insufficient.
	1 Date: YYYYMMDD
	1 Time: 24HHMMSS
	1 Card Number: Need to be hided in accordance with UnionPay regulations
	1 TRANS_TICKET_NO：For non-bank card transactions, corresponding to the transaction number in the transaction system
	1 TRANS_TRACE_NO is the only flow of transactions initiated on the PC side. The reference format is YYYYMMDD + hhmmss + serial number. TRANS_TRACE_NO It is enough to ensure the unique value of TRANS_TRACE_NO for each transaction, preferably not more than 20 digits）.
	1 TRANS_ORDER_NO：The order number of the transaction initiated on the PC
	1 TRANS_TICKET_NO：The order number of the trading system

	
3. Transaction Interface
3.1 Collection
3.1.1 Collection – Bank card
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type
		AMOUNT Required amount (12 digit-number, cent as
		unit,completes it by adding 0 on left if
		the digit numbers are insufficient)
		MEMO Memo field
		TRANS_TRACE_NO Required Transaction unique identifier
		TRANS_ORDER_NO Required Commodity order number
		CURRENCY Required Currency (refer to Appendix-Currency)
		DCC_FLAG Default EDC transaction （DCC/EDC）
		BUS_INFO Expand field

	Return Parameter
	Parameter name Required Explanation
		BUSINESS_ID Required Business type
		AMOUNT Required Amount
		CURRENCY Required Currency
		PAY_CURRENCY Payment currency
		PAY_AMOUNT Payment amount
		EXCHANGE_RATE Exchange rate
		ACTUALLY_AMOUNT Required The amount actually paid
		TRACE_NO Required Swift number
		EXP_DATE Required Valid date
		BATCH_NO Required Batch number
		MERCH_ID Required Business number
		MERCH_NAME Required Business name
		TER_ID Required Terminal number
		REF_NO Required System reference number
		AUTH_NO Required Authorization code
		REJCODE Required Return code
		CARD_ORGN Card organization
		CARDNO Required Card number
		DATE Required Transaction date
		TIME Required Transaction time
		REJCODE_CN Required Return code explanation
		MEMO Memo field
		TRANS_TRACE_NO Transaction unique identifier
		BUS_INFO Expand field
		TRANS_TICKET_NO Transaction number
		OPER_NO Operator number

3.1.2 Collection-code Scanning
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type
		AMOUNT Required
		Amount (12 -digit number, cent as
		unit,completes it by adding 0 on left
		if the digit numbers are insufficient)
		TRANS_TRACE_NO Required Transaction unique identifier
		TRANS_ORDER_NO Required Commodity order number
		CURRENCY Required Currencies
		BUS_INFO Expand field

	Return Parameters
	Parameter name Optional Explanation
		BUSINESS_ID Required Business type
		AMOUNT Required Amount
		CURRENCY Required Currencies
		TRACE_NO Required Swift number
		BATCH_NO Required Batch number
		MERCH_ID Required Business number
		MERCH_NAME Required Business name
		TER_ID Required Terminal number
		REF_NO System reference number
		REJCODE Required
		Return code explanation. When answering
		AS, the transaction result is unknown,
		and the inquiry transaction needs to be
		initiated to obtain the final
		transaction result.
		DATE Required Transaction date
		TIME Required Transaction time
		REJCODE_CN Required Return code explanation
		TRANS_TRACE_NO Transaction unique identifier
		BUS_INFO Expand field
		TRANS_CHANNEL Payment channel
		TRANS_TICKET_NO Transaction number
		OPER_NO Operator number

3.1.3 Collection – QR Code Payment
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type
		AMOUNT Required
		Amount (12-digit number, cent as unit,
		if not enough, add 0 to the left)
		TRANS_TRACE_NO Required Transaction unique identifier
		TRANS_ORDER_NO Required Commodity order number
		CURRENCY Required Currencies
		BUS_INFO Expand field
	Return Parameters
	Parameter name Optional Explanation
		BUSINESS_ID Required Business type
		AMOUNT Required Amount
		CURRENCY Required Currencies
		TRACE_NO Required Swift number
		BATCH_NO Required Batch number
		MERCH_ID Required Merchant ID
		MERCH_NAME Required Merchant name
		TER_ID Required Terminal number
		REF_NO System reference number
		REJCODE Required Return code
		DATE Required Transaction date
		TIME Required Transaction time
		REJCODE_CN Required Return code explanation
		TRANS_TRACE_NO Transaction unique identifier
		BUS_INFO Expand field
		TRANS_CHANNEL Payment channel
		PRINT_FLAG Print mark
		TRANS_TICKET_NO Transaction number
		OPER_NO Operator number
		Notes: success of the transaction return only means ordering successfully, the
		final transaction result needs to be gained by inquiry interface.

3.2 Void
3.2.1 Void – bank card
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type
		AMOUNT Required
		Amount（12 digit-number，cent as
		unit,completes it by adding 0 on left
		if the digit numbers are
		insufficient)
		ORIG_TRACE_NO Required Original transaction document number
		TRANS_TRACE_NO Required Transaction unique identifier
		CURRENCY Required
		Currency（Refers to appendixcurrencies）
		BUS_INFO Expand field

	Return Parameters
	Parameter name Optional Explanation
		BUSINESS_ID Required Business type
		AMOUNT Required Amount
		TRACE_NO Required Swift number
		ORIG_TRACE_NO Required Original swift number
		EXP_DATE Valid date
		BATCH_NO Required Batch number
		MERCH_ID Required Merchant number
		MERCH_NAME Required Merchant name
		TER_ID Required Terminal number
		REF_NO Required System reference number
		AUTH_NO Authorization code
		REJCODE Required Return code
		CARD_ORGN Card organization
		CARDNO Required Card number
		DATE Required Transaction date
		TIME Required Transaction time
		REJCODE_CN Required Return code explanation
		MEMO Remark
		TRANS_TRACE_NO Transaction unique identifier
		BUS_INFO Expand field
		ORIG_DATE Transaction date
		PRINT_FLAG Print mark
		ORIG_REF_NO Original system reference number
		TRANS_TICKET_NO Transaction number
		OPER_NO Operator number

3.2.2 Void – void by scanning code
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type
		ORIG_TRACE_NO Required Original document number
		AMOUNT Required
		Amount（12 digit-number，cent as
		unit,completes it by adding 0 on left
		if the digit numbers are insufficient)
		TRANS_TRACE_NO Required Transaction unique identifier
		BUS_INFO Expand field

	Return Parameter
	Parameter name Optional Explanation
		BUSINESS_ID Required Business type
		AMOUNT Required Amount
		TRACE_NO Required Swift number
		ORIG_TRACE_NO Required Original swift number
		EXP_DATE Valid date
		BATCH_NO Required batch number
		MERCH_ID Required Merchant number
		MERCH_NAME Required Merchant name
		TER_ID Required Terminal number
		REF_NO Required System reference number
		AUTH_NO Authorization code
		REJCODE Required Return code
		CARD_ORGN Required Payment channel
		DATE Required Transaction date
		TIME Required Transaction time
		REJCODE_CN Required Return code explanation
		TRANS_TRACE_NO Transaction unique identifier
		BUS_INFO Expand field
		TRANS_CHANNEL Payment channel
		ORIG_DATE Transaction date
		PRINT_FLAG Print mark
		TRANS_TICKET_NO Transaction number
		OPER_NO Operator number

3.3 Refund
3.3.1 Refund – bank card
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type
		AMOUNT Required
		Amount（12 digit-number，cent as
		unit,completes it by adding 0 on left
		if the digit numbers are insufficient)
		ORIG_REF_NO Required Original system reference number
		ORIG_DATE Required Original transaction date
		CURRENCY Required Currency
		TRANS_TRACE_NO Required Transaction unique identifier
		BUS_INFO Expand field

	Return Parameters
	Parameter name Optional Explanation
		BUSINESS_ID Required Business type
		AMOUNT Required Amount
		CURRENCY Required Currency
		TRACE_NO Required Swift number
		ORIG_REF_NO Required Original system reference number
		EXP_DATE Required Valid date
		BATCH_NO Required Batch number
		MERCH_ID Required Merchant number
		MERCH_NAME Required Merchant name
		TER_ID Required Terminal number
		REF_NO Required System reference number
		AUTH_NO Required Authorization code
		REJCODE Required Return code
		CARD_ORGN Card organization
		CARDNO Required Card number
		DATE Required Transaction date
		TIME Required Transaction time
		REJCODE_CN Required Return code explanation
		TRANS_TRACE_NO Transaction unique identifier
		BUS_INFO Expand field
		ORIG_DATE Original transaction date
		PRINT_FLAG Print mark
		TRANS_TICKET_NO Transaction number
		OPER_NO Operator number

3.3.2 Refund-Refund by Scanning Code
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type
		ORIG_ TRANS_TICKET_NO Required Original transaction number
		AMOUNT Required
		Amount（12 digit-number，cent as unit,
		completes it by adding 0 on left if the
		digit numbers are insufficient)
		CURRENCY Required Currency
		TRANS_TRACE_NO Required Transaction unique identifier
		BUS_INFO Expand field

	Return Parameters
	Parameter name Optional Explanation
		BUSINESS_ID Required Business type
		AMOUNT Required Amount
		CURRENCY Required Currency
		TRACE_NO Required Swift number
		EXP_DATE Valid date
		BATCH_NO Required Batch number
		MERCH_ID Required Merchant number
		MERCH_NAME Required Merchant name
		TER_ID Required Terminal number
		REF_NO Required System reference number
		AUTH_NO Authorization code
		REJCODE Required return code
		DATE Required transaction date
		TIME Required transaction time
		REJCODE_CN Required Return code explanation
		TRANS_TRACE_NO Transaction unique identifier
		BUS_INFO Expand field
		TRANS_CHANNEL Payment channel
		ORIG_DATE Original transaction date
		ORIG_TRACE_NO Original swift number
		PRINT_FLAG Print mark
		TRANS_TICKET_NO Transaction number
		OPER_NO Operator number

3.4 Inquiry
3.4.1 Transaction Result Inquiry
	For the scan code payment in the request timeout or in the clear response
	processing, this API interface needs to be called to obtain the final payment
	result.
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type
		ORIG_DATE Original transaction date
		TRANS_TRACE_NO Required
		Transaction unique identifier
		（Consistent with the original
		transaction）

	Return Parameters
	Parameter name Optional Explanation
		BUSINESS_ID Required business type
		AMOUNT Required Amount
		TRACE_NO Required Swift number
		EXP_DATE Valid date
		BATCH_NO Required Batch number
		MERCH_ID Required Merchant number
		MERCH_NAME Required Merchant name
		TER_ID Required Terminal number
		REF_NO Required System reference number
		AUTH_NO Authorization code
		REJCODE Required Return code
		DATE Required Transaction date
		TIME Required Transaction time
		REJCODE_CN Required Return code explanation
		TRANS_STATE
		Trading status (Required when REJCODE
		is 00, see appendix-transaction
		status)
		TRANS_DESC Transaction status description
		TRANS_TRACE_NO Transaction unique identifier
		TRANS_TICKET_NO Transaction number
		TRANS_CHANNEL Payment channel
		PRINT_FLAG Print mark
		OPER_NO Operator number
		MEMO Memo field

3.5. Authorization
3.5.1 Pre-authorization
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type
		AMOUNT Required
		Amount（12 digit-number，cent as
		unit,completes it by adding 0 on left
		if the digit numbers are insufficient)
		CURRENCY Required Currencies
		TRANS_TRACE_NO Transaction unique identifier
		BUS_INFO Expand field

	Return Parameters
	Parameter name Optional Explanation
		BUSINESS_ID Required Business type
		AMOUNT Required Amount
		CURRENCY Required Currency
		TRACE_NO Required Swift number
		EXP_DATE Required Valid date
		BATCH_NO Required Batch number
		MERCH_ID Required Merchant number
		MERCH_NAME Required Merchant name
		TER_ID Required Terminal number
		REF_NO Required System reference number
		AUTH_NO Required Authorization code
		REJCODE Required Return code
		CARDNO Required Card number
		DATE Required Transaction date
		TIME Required Transaction time
		REJCODE_CN Required Return code explanation
		TRANS_TRACE_NO Transaction unique identifier
		CARD_TYPE_IDENTY
		Debit and Credit Card Identification
		0: debit card; 1: credit card
		BUS_INFO Expand field
		PRINT_FLAG Print mark
		TRANS_TICKET_NO Transaction number
		OPER_NO Operator number

3.5.2 Pre-authorization Voiding
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type
		AMOUNT Required
		Amount（12 digit-number，cent as
		unit,completes it by adding 0 on left if
		the digit numbers are insufficient)
		ORIG_AUTH_NO Required
		Original authorization number（document
		number）
		TRANS_TRACE_NO Transaction unique identifier
		BUS_INFO Expand field
		CARDNO
		card number（If you don’t fill it in, the
		card reader/card number interface will pop
		up）
		Return Parameters
		Parameter name Optional Explanation
		BUSINESS_ID Required Business type
		AMOUNT Required Amount
		TRACE_NO Required Swift number
		EXP_DATE Required Valid date
		BATCH_NO Required Batch number
		MERCH_ID Required Merchant number
		MERCH_NAME Required Merchant name
		TER_ID Required Terminal number
		REF_NO Required System reference number
		AUTH_NO Required Authorization code
		REJCODE Required Return code
		CARDNO Required Card number
		ORIG_DATE Required Original transaction date
		DATE Required Transaction date
		TIME Required Transaction time
		REJCODE_CN Required Return code explanation
		TRANS_TRACE_NO Transaction unique identifier
		CARD_TYPE_IDENTY
		Debit and Credit Card
		Identification
		0: debit card; 1: credit card
		BUS_INFO Expand field
		PRINT_FLAG Print mark
		TRANS_TICKET_NO Transaction number
		OPER_NO Operator number

3.5.3 Pre-authorization Completion
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type
		ORIG_AUTH_NO Required Original authorization number
		ORIG_DATE Required Original transaction date
		AMOUNT Required
		Amount（12 digit-number，cent as
		unit,completes it by adding 0 on left if
		the digit numbers are insufficient)
		CURRENCY Required Currency
		TRANS_TRACE_NO Transaction unique identifier
		DCC_FLAG Default EDC transaction（DCC/EDC）
		BUS_INFO Expand field
		CARDNO
		If you don’t fill it in, the card
		reader/card number interface will pop
		up）

	Return Parameters
	Parameter name Optional Explanation
		AMOUNT Required Amount
		CURRENCY Required Currency
		PAY_CURRENCY Payment currency
		PAY_AMOUNT Payment amount
		EXCHANGE_RATE Exchange rate
		TRACE_NO Required Swift number
		EXP_DATE Required Valid date
		BATCH_NO Required Batch number
		MERCH_ID Required Merchant number
		MERCH_NAME Required Merchant name
		TER_ID Required Terminal number
		REF_NO Required System reference number
		AUTH_NO Required Authorization code
		REJCODE Required Return code
		CARDNO Required Card number
		ORIG_DATE Required Transaction date
		DATE Required Transaction date
		TIME Required Transaction time
		REJCODE_CN Required Return code explanation
		TRANS_TRACE_NO Transaction unique identifier
		CARD_TYPE_IDENTY
		Debit and Credit Card
		Identification
		0: debit card; 1: credit card
		BUS_INFO Expand field
		ORIG_DATE Transaction date
		PRINT_FLAG Print mark
		BUSINESS_ID Business type
		ORIG_REF_NO Original system reference number
		TRANS_TICKET_NO Transaction number
		OPER_NO Operator number

3.5.4 Voiding of Pre-authorization Completion
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type
		ORIG_TRACE_NO Required Original swift number
		AMOUNT Required
		Amount（12 digit-number，cent as
		unit,completes it by adding 0 on left
		if the digit numbers are insufficient)
		TRANS_TRACE_NO Transaction unique identifier
		BUS_INFO Expand field
		CARDNO
		If you don’t fill it in, the card
		reader/card number interface will pop
		up）

	Return Parameters
	Parameter name Optional Explanation
		AMOUNT Required Amount
		TRACE_NO Required Swift number
		ORIG_TRACE_NO Required Original swift number
		EXP_DATE Required Valid date
		BATCH_NO Required Batch number
		MERCH_ID Required Merchant number
		MERCH_NAME Required Merchant name
		TER_ID Required Terminal number
		REF_NO Required System reference number
		AUTH_NO Required Authorization code
		REJCODE Required Return code
		CARDNO Required Card number
		DATE Required Transaction date
		TIME Required Transaction time
		REJCODE_CN Required Return code explanation
		TRANS_TRACE_NO Transaction unique identifier
		CARD_TYPE_IDENTY
		Debit and Credit Card
		Identification
		0: debit card 1: credit card
		BUS_INFO Expand field
		ORIG_DATE Original transaction date
		PRINT_FLAG Print mark
		BUSINESS_ID Business type
		ORIG_REF_NO Original system reference number
		OPER_NO Operator number

3.6 Accessibility
3.6.1 Receiving Terminal Master Key
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type

	Return Parameters
	Parameter name Optional Explanation
		MERCH_ID Required Merchant number
		MERCH_NAME Required Merchant name
		TER_ID Required terminal number
		REJCODE Required return code
		REJCODE_CN Required Return code explanation
		PRINT_FLAG Print mark
		BUSINESS_ID business type

3.6.2 Terminal Sign-on
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type

	Return Parameters
	Parameter name Optional Explanation
		BATCH_NO Required Batch number
		TRACE_NO Required Swift number
		MERCH_ID Required Merchant number
		MERCH_NAME Required Merchant name
		TER_ID Required terminal number
		REJCODE Required return code
		REJCODE_CN Required Return code explanation
		PRINT_FLAG Print mark
		BUSINESS_ID business type

3.6.3 Terminal Settlement
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required business type

	Return Parameters
	Parameter name Optional Explanation
		BUSINESS_ID Required Business type
		BATCH_NO Required batch number
		TRACE_NO Required Original swift number
		MERCH_ID Required Merchant number
		MERCH_NAME Required Merchant name
		TER_ID Required terminal number
		REJCODE Required return code
		REJCODE_CN Required Return code explanation
		TIME transaction time
		DATE transaction date
		PRINT_FLAG Print mark
		OPER_NO Operator number

3.6.4 Reprinting a Receipt
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type
		ORIG_TRACE_NO Required Original swift number
		TRANS_TRACE_NO Transaction unique identifier

	Return Parameters
	Parameter name Optional Explanation
		AMOUNT Required Amount
		TRACE_NO Required Swift number
		ORIG_TRACE_NO Original swift number
		ORIG_REF_NO Original system reference number
		EXP_DATE valid date
		BATCH_NO Required batch number
		MERCH_ID Required Merchant number
		MERCH_NAME Required Merchant name
		TER_ID Required Terminal number
		REF_NO Required System reference number
		AUTH_NO Authorization code
		REJCODE Required Return code
		CARD_ORGN Card organization or Wallet agency
		CARDNO Card number
		DATE Required Transaction date
		TIME Required Transaction time
		REJCODE_CN Required Return code explanation
		TRANS_TRACE_NO Required Transaction unique identifier
		BUS_INFO Expand field
		PRINT_FLAG Print mark
		BUSINESS_ID Business type
		OPER_NO Operator number

3.6.5 Reprinting the Purchase Order
	Request Parameters
	Parameter name Required Explanation
		OPER_NO Operator number
		BUSINESS_ID Required Business type
		TRANS_TRACE_NO Transaction unique identifier

	Return Parameters
	Parameter name Optional Explanation
		AMOUNT Required Amount
		TRACE_NO Required Swift number
		ORIG_TRACE_NO Original swift number
		ORIG_REF_NO Original system reference number
		EXP_DATE valid date
		BATCH_NO Required batch number
		MERCH_ID Required Merchant number
		MERCH_NAME Required Merchant name
		TER_ID Required Terminal number
		REF_NO Required System reference number
		AUTH_NO Authorization code
		REJCODE Required Return code
		CARD_ORGN Card organization or wallet agency
		CARDNO Card number
		DATE Required Transaction date
		TIME Required Transaction time
		REJCODE_CN Required Return code explanation
		TRANS_TRACE_NO Required Transaction unique identifier
		BUS_INFO Expand field
		PRINT_FLAG Print mark
		BUSINESS_ID Business type
		OPER_NO Operator number

3.7 Foreign Service
3.7.1 Getting Device Information
	Request Parameters
	Parameter name Required Explanation
		BUSINESS_ID Required Business type
	Return Parameters
	Parameter name Optional Explanation
		BUSINESS_ID Required Business type
		SN Required devise serial number
		MODEL Required Device model
		VENDOR Required Terminal brand
		VERSIONCODE Required Driver version number
		CERTIFICATION Required Network license number
		REJCODE Required return code
		REJCODE_CN Required Return code explanation
		PRINT_FLAG Print mark
		MERCH_ID Merchant number
		MERCH_NAME Merchant name
		TER_ID terminal number

4. Parameters Description -> refer the document for detail