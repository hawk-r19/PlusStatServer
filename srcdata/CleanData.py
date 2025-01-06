import pandas as pd

input_data = pd.read_csv("SumitroDatta/PlayerPerGame.csv")

print(input_data[:5].to_string())