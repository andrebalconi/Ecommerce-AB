import { Paper, Typography } from "@mui/material";
import { Container } from "@mui/system";

export default function ServerError () {
    return (
        <Container component={Paper}>
            <Typography variant="h5" gutterBottom>Server error</Typography>
        </Container>
    )
}