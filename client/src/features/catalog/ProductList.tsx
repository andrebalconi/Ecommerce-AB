import { Grid } from '@mui/material'
import { Product } from '../../app/models/product'
import { useAppSelector } from '../../app/store/configureStore'
import ProductCard from './ProductCard'
import ProductCardSkeleton from './ProductCardSkeleton'

interface Props {
  products: Product[]
}

export default function ProductList({ products }: Props) {
  const { productsLoaded } = useAppSelector((state) => state.catalog)
  return (
    <Grid container spacing={{ xs: 2, md: 3 }} columns={{ xs: 4, sm: 8, md: 12 }}>
      {products.map((product) => (
        <Grid item xs={4} key={product.id}>
          {!productsLoaded ? (
            <ProductCardSkeleton />
          ) : (
            <ProductCard product={product} />
          )}
        </Grid>
      ))}
    </Grid>
  )
}
