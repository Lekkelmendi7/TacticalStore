import { AppBar, Toolbar, Typography } from "@mui/material";


export default function Header(){
    return(
        <AppBar position='static' sx={{mb: 4, bgcolor:"olive"}}>
            <Toolbar>
                <Typography>
                    CAMOUFLAGEE
                </Typography>
            </Toolbar>
        </AppBar>
    )
}