# 基本イメージとして公式の .NET SDK イメージを使用
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# 作業ディレクトリを設定
WORKDIR /app

# ソリューションファイルをコピーして復元
COPY todo-backend.sln ./
COPY todo-backend/*.csproj ./todo-backend/
RUN dotnet restore

# 残りのソースコードをコピーしてビルド
COPY . ./
RUN dotnet publish -c Release -o out

# 実行環境として公式の .NET ランタイム イメージを使用
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# 作業ディレクトリを設定
WORKDIR /app

# ビルド成果物をコピー
COPY --from=build /app/out ./

# アプリケーションを実行
ENTRYPOINT ["dotnet", "todo-backend.dll"]
