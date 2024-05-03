# -*- coding: utf-8 -*-
from gradio_client import Client

client = Client("ysharma/Chat_with_Meta_llama3_8b")
result = client.predict(
		message="Как сдать на права управления авто?",
		request=0.95,
		param_3=512,
		api_name="/chat"
)[11:]

print(result)