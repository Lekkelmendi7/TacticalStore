import { AppBar, Switch, Toolbar, Typography } from "@mui/material";

interface Props{ 
    darkMode: boolean;
    handleThemeChange: () => void;
}


export default function Header({handleThemeChange, darkMode}: Props){
    return(
        <AppBar position='static' sx={{mb: 4, bgcolor:"olive"}}>
            <Toolbar>
                <Typography>
                    CAMOUFLAGE
                </Typography>
                <Switch checked={darkMode} onChange={handleThemeChange}/>
            </Toolbar>
        </AppBar>
    )
}