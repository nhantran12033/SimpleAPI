
export interface ExpenseDto {
  id?: string;
  informationsId?: string;
  purpose?: string;
  destination?: string;
  checkinTime?: string;
  checkoutTime?: string;
  totalNights: number;
  totalAmount: number;
  itemDetail: ItemDto[];
}

export interface InformationDto {
  id?: string;
  operaterName?: string;
  requestNumber?: string;
  requestDate?: string;
  legalEntity?: string;
  department?: string;
  verifierUsername?: string;
  verifierName?: string;
  expenseCode?: string;
  businessType?: string;
  notes?: string;
  expenseDetail: ExpenseDto[];
}

export interface ItemDto {
  id?: string;
  expensesId?: string;
  item?: string;
  specification?: string;
  originalCurrency?: string;
  originalUnit: number;
  volume: number;
  originalAmount: number;
  equivalentInVND: number;
  notes?: string;
}
