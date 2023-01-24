import Typography from '@mui/material/Typography'
import Grid from '@mui/material/Grid'
import TextField from '@mui/material/TextField'
import FormControlLabel from '@mui/material/FormControlLabel'
import Checkbox from '@mui/material/Checkbox'
import { useFormContext } from 'react-hook-form'
import AppTextInput from '../../app/components/AppTextInput'

export default function PaymentForm() {
  const { control } = useFormContext()
  return (
    <>
      <Typography variant="h6" gutterBottom>
        Payment method
      </Typography>
      <Grid container spacing={3}>
        <Grid item xs={12} md={6}>
          <AppTextInput name='nameOnCard' label='Name on card' control={control} />
        </Grid>
        <Grid item xs={12} md={6}>
          <AppTextInput name='cardNumber' label='Card Number' control={control}/>
        </Grid>
        <Grid item xs={12} md={6}>
          <AppTextInput name='expDate' label='Expiry date' control={control}/>
        </Grid>
        <Grid item xs={12} md={6}>
          <AppTextInput name='cvv' label='CVV' control={control}/>
        </Grid>
        <Grid item xs={12}>
          <FormControlLabel
            control={<Checkbox color="secondary" name="saveCard" value="yes" />}
            label="Remember credit card details for next time"
          />
        </Grid>
      </Grid>
    </>
  )
}
