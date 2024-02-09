export interface Product {
id: number;
name: string;
description?:string;
purchasePrice: number;
sellingPrice: number;
stokeQuantity: number;
expiryDate: Date;
urlImage?: string;
}
