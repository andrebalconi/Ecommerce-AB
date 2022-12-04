import { useState, useEffect } from "react";
import { Product } from "../../app/models/product";
import ProductList from "./ProductList";



export default function Catalog() {
    const [products, setProducts] = useState<Product[]>([]);

  useEffect(() => {
    fetch('http://localhost:5208/api/Products')
    .then(response => response.json())
    .then(data => setProducts(data))
  }, [])

    return (
        <>
            <ProductList products={products} />
      </>
    )
}