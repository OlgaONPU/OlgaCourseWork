export interface Product {
    id: number;
    link: string;
    type: string;
    photos: Array<string>;
    description: Description;
}

export interface Description {
    title: string;
    width: number;
    height: number;
    depth: number;
    price: number;
}
