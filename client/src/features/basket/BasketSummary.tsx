import { TableContainer, Paper, Table, TableBody, TableRow, TableCell, Typography } from "@mui/material";
import { useEffect, useState } from "react";
import agent from "../../app/api/agent";
import { useStoreContext } from "../../app/context/StoreContext";
import { Basket } from "../../app/models/basket";
import { currencyFormat } from "../../app/util/util";

export default function BasketSummary() {
    const [basket, setBasket] = useState<Basket | null>(null);

    const [status, setStatus] = useState({
        loading: false,
        name: '',
      })
    useEffect(() => {
        agent.Basket.get()
          .then((basket) => setBasket(basket))
          .catch((error) => console.log(error))
          .finally(() => setStatus({ loading: false, name: '' }))
      })

    const subtotal = basket?.items.reduce((sum, item) => sum + (item.quantity * item.price), 0) ?? 0;
    const deliveryFee = subtotal > 10000 ? 0: 500;

    return (
        <>
            <TableContainer component={Paper} variant={'outlined'}>
                <Table>
                    <TableBody>
                        <TableRow>
                            <TableCell colSpan={2}>Subtotal</TableCell>
                            <TableCell align="right">{currencyFormat(subtotal)}</TableCell>
                        </TableRow>
                        <TableRow>
                            <TableCell colSpan={2}>Delivery fee*</TableCell>
                            <TableCell align="right">{currencyFormat(deliveryFee)}</TableCell>
                        </TableRow>
                        <TableRow>
                            <TableCell colSpan={2}>Total</TableCell>
                            <TableCell align="right">{currencyFormat(subtotal + deliveryFee)}</TableCell>
                        </TableRow>
                        <TableRow>
                            <TableCell>
                                <span style={{fontStyle: 'italic'}}>*Orders over $100 qualify for free delivery</span>
                            </TableCell>
                        </TableRow>
                    </TableBody>
                </Table>
            </TableContainer>
        </>
    )
} 